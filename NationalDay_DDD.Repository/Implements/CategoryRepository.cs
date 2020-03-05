using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Models;
using NationalDay_DDD.Infrastruct.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Repository.Implements
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public override void GetDb()
        {
            Db = AbstractDbFactory.GetProductContextDbContext();
        }


    }
}
