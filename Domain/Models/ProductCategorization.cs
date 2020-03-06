using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class ProductCategorization: AggregateRoot<ProductCategorization>
    {
        public ProductCategorization()
        { }

        public ProductCategorization(int productId, int categoryId)
        {
            this.CategoryId = categoryId;
            this.ProductId = productId;
        }

        /// <summary>
        /// 分类id
        /// </summary>
        public int CategoryId { get; private set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { get; private set; }
    }
}
