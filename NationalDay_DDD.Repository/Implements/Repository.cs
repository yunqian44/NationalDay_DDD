using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NationalDay_DDD.Repository.Implements
{
    /// <summary>
    /// 基类仓储
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public abstract class Repository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
    {
        /// <summary>
        /// 数据上下文
        /// </summary>
        public DbContext CurrentContext { get; set; }

        protected abstract void GetContext();

        public Repository()
        {
            GetContext();
        }

        public TAggregateRoot Get(int id)
        {
            return default(TAggregateRoot);
        }

        public void Add(TAggregateRoot aggregateRoot)
        {

        }

        public void Update(TAggregateRoot aggregateRoot)
        {

        }

        public void Remove(TAggregateRoot aggregateRoot)
        {

        }

        public IEnumerable<TAggregateRoot> GetAll()
        {
            return null;
        }

        public IEnumerable<TAggregateRoot> Find(Expression<Func<TAggregateRoot, bool>> conditions)
        {
            return null;
        }
    }
}
