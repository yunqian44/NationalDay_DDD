using MediatR;
using MediatR.Internal;
using NationalDay_DDD.Core.Bus;
using NationalDay_DDD.Core.Commands;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NationalDay_DDD.Infrastruct.Bus
{
    /// <summary>
    /// 一个密封类，实现我们的中介记忆总线
    /// </summary>
    public sealed class InMemoryBus : IMediatorHandler
    {
        //构造函数注入
        private readonly IMediator _mediator;
        //注入服务工厂
        private readonly ServiceFactory _serviceFactory;
        private static readonly ConcurrentDictionary<Type, object> _requestHandlers = new ConcurrentDictionary<Type, object>();
       
        public InMemoryBus(IMediator mediator,ServiceFactory serviceFactory)
        {
            _mediator = mediator;
            _serviceFactory = serviceFactory;
        }

        /// <summary>
        /// 实现我们在IMediatorHandler中定义的接口
        /// 没有返回值
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="command">命令模型</param>
        /// <returns></returns>
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);//这里要注意下 command 对象 command 得继承IRequest

            //注意！这个仅仅是用来测试和研究源码的，请开发的时候不要使用这个
            //return Send(command);//请注意 入参 的类型
        }
    }
}
