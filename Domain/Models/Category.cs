using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 类别
    /// </summary>
    public class Category: AggregateRoot<Category>
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 类别描述
        /// </summary>
        public string Description { get; private set; }
    }
}
