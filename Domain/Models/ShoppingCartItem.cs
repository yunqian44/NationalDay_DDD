using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class ShoppingCartItem : AggregateRoot<ShoppingCartItem>
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; private set; }

        /// <summary>
        /// 产品
        /// </summary>
        public virtual Product Product { get; private set; }

        /// <summary>
        /// 购物车
        /// </summary>
        public virtual ShoppingCart ShoopingCart { get; private set; }

        /// <summary>
        ///总金额
        /// </summary>
        public decimal ItemAmount
        {
            get
            {
                return this.Product.UnitPrice * this.Quantity;
            }
        }
    }
}
