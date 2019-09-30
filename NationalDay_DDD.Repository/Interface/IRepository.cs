using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NationalDay_DDD.Repository.Interface
{
    public interface IRepository<TEntity> :IDisposable where TEntity : class

    {
        /// <summary>
        /// 根据Id获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(int id);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Add(TEntity aggregateRoot);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Update(TEntity aggregateRoot);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Remove(TEntity aggregateRoot);

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// 查询根据条件
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> conditions);
    }
}
