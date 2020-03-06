using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Infrastruct.Context
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options)
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

        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> Users
        {
            get { return Set<User>(); }
        }

        public DbSet<ShoppingCart> ShoppingCarts
        {
            get { return Set<ShoppingCart>(); }
        }

        public DbSet<ProductCategorization> ProductCategorizations
        {
            get { return Set<ProductCategorization>(); }
        }

        public DbSet<UserRole> UserRoles
        {
            get { return Set<UserRole>(); }
        }

        public DbSet<Role> Roles
        {
            get { return Set<Role>(); }
        }

        public DbSet<Order> Orders
        {
            get { return Set<Order>(); }
        }

    }
}
