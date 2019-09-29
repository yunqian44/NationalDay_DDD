using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Mapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NationalDay_DDD.Infrastruct.Data.Context
{
    /// <summary>
    /// 定义核心子领域-学习上下文
    /// </summary>
    public class UserContext:DbContext
    {

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// 重写自定义Map配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 重写连接数据库
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 从 appsetting.json 中获取配置信息
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // 定义要使用的数据库
            //optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));

            var optionBuilder= new DbContextOptionsBuilder<UserContext>().UseMySql(config.GetConnectionString("DefaultConnection"));

            var context = new UserContext(optionBuilder.Options);
        }
    }
}
