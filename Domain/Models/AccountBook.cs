using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 记账本
    /// </summary>
    public class AccountBook: AggregateRoot<AccountBook>
    {
        public List<OverheadItem> OverheadItems { get; private set; }

        //ctor

        // 记账薄的行为
        // ....
    }
}
