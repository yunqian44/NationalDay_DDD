using AutoMapper;
using NationalDay_DDD.Application.Interface;
using NationalDay_DDD.Application.ViewModel;
using NationalDay_DDD.Core.Bus;
using NationalDay_DDD.Domain.Commands;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Application.Implements
{
    /// <summary>
    /// UserService 服务接口实现类,继承 服务接口
    /// 通过 DTO 实现视图模型和领域模型的关系处理
    /// 作为调度者，协调领域层和基础层，
    /// 这里只是做一个面向用户用例的服务接口,不包含业务规则或者知识
    /// </summary>
    public class UserService : IUserService
    {
        // 注意这里是要IoC依赖注入的，还没有实现
        private readonly IUserRepository _UserRepository;
        // 用来进行DTO
        private readonly IMapper _mapper;

        //中介者 总线
        private readonly IMediatorHandler _bus;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UserService(IUserRepository userRepository,IMapper mapper, IMediatorHandler bus) 
        {
            _UserRepository = userRepository;
            _mapper = mapper;
            _bus = bus;
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            //第一种写法 Map
            return _mapper.Map<IEnumerable<UserViewModel>>(_UserRepository.GetAll());
        }

        public IEnumerable<UserViewModel> GetAllHistory(int id)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Register(UserViewModel userViewModel)
        {

            //RegisterUserCommand registerUserCommand = new RegisterUserCommand(userViewModel.........ewModel.Phone);
            ////如果命令无效，证明有错误
            //if (!registerUserCommand.IsValid())
            //{
            //    List<string> errorInfo = new List<string>();
            //    //获取到错误，请思考这个Result从哪里来的 

            //    //.....

            //    //对错误进行记录，还需要抛给前台
            //    ViewBag.ErrorData = errorInfo;
            //}

            _UserRepository.Add(_mapper.Map<User>(userViewModel));
            _UserRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserViewModel StudentViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
