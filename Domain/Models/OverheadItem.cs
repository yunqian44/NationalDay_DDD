using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class OverheadItem: Entity
    {
        //开销内容
        public OverheadContent Content { get; private set; }

        //开销金额
        public decimal Money { get; private set; }

        // ctor

        // 开销项目的行为
        // ....
    }
}
