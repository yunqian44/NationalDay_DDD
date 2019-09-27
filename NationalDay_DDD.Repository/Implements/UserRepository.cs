using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.Infrastruct.Factory;
using NationalDay_DDD.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Repository.Implements
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        protected override void GetContext()
        {
            //CurrentContext = AbstractCurrentFactory.GetUserCurrentDbContext();
        }
    }
}
