using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Core.Models
{
    public class AggregateRoot<TAggregate> : IAggregateRoot
        where TAggregate : AggregateRoot<TAggregate>
    {
        public int Id { get; set; }
    }
}
