﻿using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
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
        protected  DbContext Db;

        protected readonly DbSet<TEntity> DbSet;

        public abstract void GetDb();//抽象方法，子类必须实现

        public Repository()
        {
            GetDb();//抽象方法
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Get(int id)
        {
            return default(TEntity);
        }

        public virtual void Add(TEntity aggregateRoot)
        {
            DbSet.Add(aggregateRoot);
        }

        public virtual void Update(TEntity aggregateRoot)
        {

        }

        public virtual void Remove(TEntity aggregateRoot)
        {

        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> conditions)
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
