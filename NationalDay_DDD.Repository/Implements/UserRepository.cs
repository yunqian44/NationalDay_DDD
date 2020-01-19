using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.Infrastruct.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalDay_DDD.Repository.Implements
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public override void GetDb()
        {
            Db = AbstractDbFactory.GetUserCurrentDbContext();
        }

        public User GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
