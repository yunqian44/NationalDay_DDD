﻿using MediatR;
using Microsoft.Extensions.Caching.Memory;
using NationalDay_DDD.Core.Bus;
using NationalDay_DDD.Core.Notifications;
using NationalDay_DDD.Domain.Commands;
using NationalDay_DDD.Domain.Events;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NationalDay_DDD.Domain.CommandHandlers
{
    /// <summary>
    /// User命令处理程序
    /// 用来处理该User下的所有命令
    /// 注意必须要继承接口IRequestHandler<,>，这样才能实现各个命令的Handle方法
    /// </summary>
    public class UserCommandHandler : CommandHandler,
        IRequestHandler<RegisterUserCommand, Unit>
    {
        // 注入仓储接口
        private readonly IUserRepository _userRepository;
        // 注入总线
        private readonly IMediatorHandler _bus;
        private IMemoryCache _cache;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="uow"></param>
        /// <param name="bus"></param>
        /// <param name="cache"></param>
        public UserCommandHandler(IUserRepository studentRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      IMemoryCache cache
                                      ) : base(uow, bus, cache)
        {
            _userRepository = studentRepository;
            _bus = bus;
            _cache = cache;
        }

        // RegisterUserCommand命令的处理程序
        // 整个命令处理程序的核心都在这里
        // 不仅包括命令验证的收集，持久化，还有领域事件和通知的添加
        public Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            // 命令验证
            if (!request.IsValid())
            {
                // 错误信息收集
                NotifyValidationErrors(request);
                return Task.FromResult(new Unit());
            }

            // 实例化领域模型，这里才真正的用到了领域模型
            // 注意这里是通过构造函数方法实现
            var address = new Address(request.Province, request.City,
            request.County, request.Street);
            var user = new User(request.Name, request.Email, request.Phone, request.BirthDate, address);

            // 判断邮箱是否存在
            // 这些业务逻辑，当然要在领域层中（领域命令处理程序中）进行处理
            if (_userRepository.GetByEmail(user.Email) != null)
            {
                //这里对错误信息进行发布，目前采用缓存形式
                //List<string> errorInfo = new List<string>() { "该用户邮箱已被占用！" };
                //_cache.Set("ErrorData", errorInfo);
                //引发错误事件
                _bus.RaiseEvent(new DomainNotification("","该邮箱已经被使用！"));
                return Task.FromResult(new Unit());
            }

            // 持久化
            _userRepository.Add(user);

            // 统一提交
            if (Commit())
            {
                // 提交成功后，这里需要发布领域事件
                // 比如欢迎用户注册邮件呀，短信呀等

                // waiting....
                _bus.RaiseEvent(new UserRegisteredEvent(user.Name, user.Email, user.Birthday, user.Phone));
            }

            return Task.FromResult(new Unit());

        }

        // 手动回收
        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
