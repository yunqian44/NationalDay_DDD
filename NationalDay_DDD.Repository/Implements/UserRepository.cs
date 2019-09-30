using Microsoft.EntityFrameworkCore;
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
        public UserRepository(UserContext context)
        : base(context)
        {

        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
