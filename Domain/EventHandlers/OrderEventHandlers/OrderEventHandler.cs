using MediatR;
using NationalDay_DDD.Domain.Events;
using NationalDay_DDD.Domain.Events.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NationalDay_DDD.Domain.EventHandlers.OrderEventHandlers
{
    /// <summary>
    /// Order事件处理程序
    /// 继承INotificationHandler<T>，可以同时处理多个不同的事件模型
    /// </summary>
    public class OrderEventHandler :
        INotificationHandler<OrderConfirmedEvent>,
        INotificationHandler<OrderDispatchedEvent>
    {
        // 学习被注册成功后的事件处理方法
        public Task Handle(UserRegisteredEvent message, CancellationToken cancellationToken)
        {
            // 恭喜您，注册成功，欢迎加入我们。

            return Task.CompletedTask;
        }

        /// <summary>
        /// 订单确认后的事件的事件处理方法
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task Handle(OrderConfirmedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// 订单发货后的事件的事件处理方法
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task Handle(OrderDispatchedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
