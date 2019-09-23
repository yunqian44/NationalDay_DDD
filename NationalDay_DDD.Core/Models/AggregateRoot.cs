using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Core.Models
{
    /// <summary>
    /// 定义领域实聚合根基类
    /// </summary>
    /// <typeparam name="TAggregate"></typeparam>
    public class AggregateRoot<TAggregate> : IAggregateRoot
        where TAggregate : AggregateRoot<TAggregate>
    {
        public int Id { get; set; }
    }
}
