using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Infrastruct.UoW
{
    /// <summary>
    /// 工作单元类
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        //数据库上下文
        private readonly UserContext _context;

        //构造函数注入
        public UnitOfWork(UserContext context)
        {
            _context = context;
        }

        //上下文提交
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        //手动回收
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
