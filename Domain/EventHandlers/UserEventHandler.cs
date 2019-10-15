using MediatR;
using NationalDay_DDD.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NationalDay_DDD.Domain.EventHandlers
{
    /// <summary>
    /// Student事件处理程序
    /// 继承INotificationHandler<T>，可以同时处理多个不同的事件模型
    /// </summary>
    public class UserEventHandler :
        INotificationHandler<UserRegisteredEvent>
    {
        // 学习被注册成功后的事件处理方法
        public Task Handle(UserRegisteredEvent message, CancellationToken cancellationToken)
        {
            // 恭喜您，注册成功，欢迎加入我们。

            return Task.CompletedTask;
        }
    }
}
