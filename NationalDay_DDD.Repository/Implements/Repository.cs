using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.Repository.Interface;
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
    public abstract class Repository<TEntity> :IRepository<TEntity> where TEntity : class
    {
        protected readonly UserContext Db;

        protected readonly DbSet<TEntity> DbSet;

        public Repository(UserContext context)
        {
            Db = context;
        }

        public TEntity Get(int id)
        {
            return default(TEntity);
        }

        public void Add(TEntity aggregateRoot)
        {

        }

        public void Update(TEntity aggregateRoot)
        {

        }

        public void Remove(TEntity aggregateRoot)
        {

        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> conditions)
        {
            return null;
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
