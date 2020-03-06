using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class OrderItem : Entity
    {
        public int Quantity { get; private set; }

        public virtual Product Product { get; private set; }

        // 包含当前订单项的订单对象
        public virtual Order Order { get; private set; }

        public decimal ItemAmout
        {
            get
            {
                return this.Product.UnitPrice * this.Quantity;
            }
        }
    }
}
