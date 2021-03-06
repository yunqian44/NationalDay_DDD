﻿using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 商品类
    /// </summary>
    public class Product : AggregateRoot<Product>
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 类别
        /// </summary>
        public Category CategoryType { get; private set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; private set; }

        /// <summary>
        /// 封面图片
        /// </summary>
        public string ImageUrl { get; private set; }

        /// <summary>
        /// 是否是新品
        /// </summary>
        public bool IsNew { get; private set; }
    }
}
