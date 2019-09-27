using NationalDay_DDD.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Application.Interface
{
    /// <summary>
    /// 定义 IUserService 服务接口
    /// 并继承IDisposable，显式释放资源
    /// 注意这里我们使用的对象，是视图对象模型
    /// </summary>
    public interface IUserService:IApplicationService<UserViewModel>,IDisposable
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userViewModel"></param>
        void Register(UserViewModel userViewModel);
    }
}
