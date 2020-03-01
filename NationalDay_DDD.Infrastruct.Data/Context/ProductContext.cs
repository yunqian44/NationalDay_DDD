using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Infrastruct.Context
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<ProductContext> Products { get; set; }
    }
}
