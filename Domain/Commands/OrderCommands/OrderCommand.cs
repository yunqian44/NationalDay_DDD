﻿using NationalDay_DDD.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Commands.OrderCommands
{
    //定义一个抽象的 Order 命令模型
    /// 继承 Command
    /// 这个模型主要作用就是用来创建命令动作的，不是用来实例化存数据的，所以是一个抽象类
    public abstract class OrderCommand : Command
    {
        public int Id { get; protected set; }//注意：set 都是 protected 的

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public string Phone { get; protected set; }

        public string Province { get; protected set; }

        public string City { get; protected set; }

        public string County { get; protected set; }

        public string Street { get; protected set; }
    }
}
