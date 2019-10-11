﻿using NationalDay_DDD.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NationalDay_DDD.Core.Bus
{
    /// <summary>
    /// 中介处理程序接口
    /// 可以定义多个处理程序
    /// 是异步的
    /// </summary>
    public interface IMediatorHandler
    {
        /// <summary>
        /// 发布命令，将我们的命令模型发布到中介者模块
        /// </summary>
        /// <typeparam name="T"> 泛型 </typeparam>
        /// <param name="command"> 命令模型，比如RegisterUserCommand </param>
        /// <returns></returns>
        Task SendCommand<T>(T command) where T : Command;
    }
}
