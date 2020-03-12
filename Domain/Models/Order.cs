using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class Order : AggregateRoot<Order>
    {
        private List<OrderItem> _orderItems = new List<OrderItem>();

        #region Public Properties
        // 获取或设置订单的状态
        public OrderStatus Status { get; set; }

        /// <summary>
        /// 获取或设置订单的创建日期
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 获取或设置订单的发货日期
        /// </summary>
        public DateTime? DispatchedDate { get; set; }

        /// <summary>
        /// 获取或设置订单的派送日期
        /// </summary>
        public DateTime? DeliveredDate { get; set; }

        public virtual List<OrderItem> OrderItems
        {
            get
            {
                return _orderItems;
            }
            set
            {
                _orderItems = value;
            }
        }

        public virtual User User { get; set; }

        public Address Address
        {
            get
            {
                return User.Address;
            }
        }
        

        #endregion 

        #region Ctor
        public Order()
        {
            CreatedDate = DateTime.Now;
            Status = OrderStatus.Created;
        }
        #endregion 
    }
}
