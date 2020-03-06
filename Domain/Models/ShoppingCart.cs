using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class ShoppingCart : AggregateRoot<ShoppingCart>
    {
        public User User { get; private set; }
    }
}
