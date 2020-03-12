using NationalDay_DDD.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Events.Order
{
    /// <summary>
    /// 订单进行确认事件
    /// </summary>
    public class OrderConfirmedEvent: Event
    {
        // 构造函数初始化，整体事件是一个值对象
        public OrderConfirmedEvent(DateTime confirmedDate, string userEmailAddress, Guid orderId)
        {
            ConfirmedDate = confirmedDate;
            UserEmailAddress = userEmailAddress;
            OrderId = orderId;
        }
        /// <summary>
        /// 获取或设置订单确认的日期。
        /// </summary>
        public DateTime ConfirmedDate { get; set; }
        public string UserEmailAddress { get; set; }
        public Guid OrderId { get; set; }
    }
}
