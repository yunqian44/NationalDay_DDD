using FluentValidation.Results;
using MediatR;
using NationalDay_DDD.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Core.Commands
{
    /// <summary>
    /// 抽象命令基类
    /// </summary>
    public abstract class Command: Message
    {
        //时间戳
        public DateTime Timestamp { get; private set; }

        //验证结果，需要引用FluentValidation
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        //定义抽象方法，是否有效
        public abstract bool IsValid();
    }
}
