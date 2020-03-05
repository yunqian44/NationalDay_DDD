using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Infrastruct.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        //public DbSet<Product> Products { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public DbSet<Product> Products
        {
            get { return this.Set<Product>(); }
        }

        /// <summary>
        /// 类别
        /// </summary>
        public DbSet<Category> Categories
        {
            get { return this.Set<Category>(); }
        }



    }
}
