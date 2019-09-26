using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NationalDay_DDD.Core.Repository
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
    {
        //IRepositoryContext Context { get; }

        TAggregateRoot Get(int id);

        void Add(TAggregateRoot aggregateRoot);

        void Update(TAggregateRoot aggregateRoot);

        void Remove(TAggregateRoot aggregateRoot);

        [Obsolete("Becareful, you must need kown what are you doing!")]
        IEnumerable<TAggregateRoot> GetAll();

        IEnumerable<TAggregateRoot> Find(Expression<Func<TAggregateRoot, bool>> conditions);
    }
}
