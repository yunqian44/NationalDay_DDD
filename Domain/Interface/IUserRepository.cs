using NationalDay_DDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Interface
{
    /// <summary>
    /// IUserRepository接口
    /// </summary>
    public interface IUserRepository:IRepository<User>
    {
        //一些User独有的接口
        User GetByEmail(string email);
    }
}
