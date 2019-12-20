using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NationalDay_DDD.Domain.Models.Enum
{
    /// <summary>
    /// 行程状态
    /// </summary>
    public enum ItineraryStatus 
    {
        /// <summary>
        /// 创建
        /// </summary>
        [Description("创建")]
        Created =0,

        /// <summary>
        /// 进行中
        /// </summary>
        [Description("进行中")]
        OnGoing =1,

        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Finished=2
    }
}
