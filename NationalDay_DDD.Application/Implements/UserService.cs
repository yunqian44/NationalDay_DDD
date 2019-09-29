using AutoMapper;
using NationalDay_DDD.Application.Interface;
using NationalDay_DDD.Application.ViewModel;
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

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UserService(IUserRepository userRepository) 
        {
            _UserRepository = userRepository;
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
            throw new NotImplementedException();
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
