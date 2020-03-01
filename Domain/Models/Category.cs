using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 类别
    /// </summary>
    public class Category:AggregateRoot<Category>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
