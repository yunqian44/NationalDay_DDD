using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.Infrastruct.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalDay_DDD.Repository.Implements
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public override void GetDb()
        {
            Db = AbstractDbFactory.GetUserCurrentDbContext();
        }

        #region 01，获取用户根据邮箱+async Task<User> GetByEmail(string email)
        /// <summary>
        /// 获取用户根据邮箱
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <returns></returns>
        public async Task<User> GetByEmail(string email)
        {
            //返回一个新查询，其中返回的实体将不会在 System.Data.Entity.DbContext 中进行缓存
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
        } 
        #endregion
    }
}
