using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Core;
using NationalDay_DDD.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Infrastruct.Factory
{
    public class AbstractCurrentFactory
    {

        public static DbContext GetUserCurrentDbContext()
        {
            //一次请求公用一个实例.上下文都可以做到切换
            //return new DataModelContainer();
            DbContext db = CallContext.GetData("UserContext") as UserContext;
            if (db == null)
            {
                //db = new UserContext();
                CallContext.SetData("UserContext", db);
            }
            return db;
        }
    }
}