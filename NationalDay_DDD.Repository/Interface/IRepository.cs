using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NationalDay_DDD.Repository.Interface
{
    public interface IRepository<TAggregateRoot>:IDisposable where TAggregateRoot : IAggregateRoot
    {
        /// <summary>
        /// 根据Id获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TAggregateRoot Get(int id);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Add(TAggregateRoot aggregateRoot);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Update(TAggregateRoot aggregateRoot);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="aggregateRoot"></param>
        void Remove(TAggregateRoot aggregateRoot);

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> GetAll();

        /// <summary>
        /// 查询根据条件
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> Find(Expression<Func<TAggregateRoot, bool>> conditions);
    }
}
