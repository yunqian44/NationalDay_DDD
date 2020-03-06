using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {
        Created = 0, // 订单已被创建
        Paid = 1, // 订单已付款
        Picked = 2, // 订单已仓库拣货
        Dispatched = 3, // 已发货
        Delivered = 4 // 已派送
    }
}
