using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 开销内容
    /// </summary>
    public class OverheadContent : AggregateRoot<OverheadContent>
    {
        public OverheadContent()
        {
            
        }

        /// <summary>
        /// 消费内容
        /// </summary>
        public List<string> Contents { get; private set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// 消费地址
        /// </summary>
        public Address address { get; private set; }
    }
}
