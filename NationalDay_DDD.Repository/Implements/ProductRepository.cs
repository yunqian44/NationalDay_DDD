using Microsoft.EntityFrameworkCore;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Domain.Models;
using NationalDay_DDD.Infrastruct.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NationalDay_DDD.Repository.Implements
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public override void GetDb()
        {
            Db = AbstractDbFactory.GetProductContextDbContext();
        }

        #region 01,Get New Product Recommended  based on Conditions+Task<List<Product>> GetNewProducts<S>(int pageSize, int pageIndex, bool isAsc, Expression<Func<Product, bool>> conditionsLambda, Expression<Func<Product, S>> orderByLambda)
        /// <summary>
        /// Get New Product Recommended  based on Conditions
        /// </summary>
        /// <param name="conditions">Conditions</param>
        /// <returns></returns>
        public async Task<List<Product>> GetNewProducts<S>(int pageSize, int pageIndex, bool isAsc, Expression<Func<Product, bool>> conditionsLambda, Expression<Func<Product, S>> orderByLambda)
        {
            if (this.DbSet == null)
                return null;

            if (isAsc)
            {
                return await  DbSet.Where(conditionsLambda)
                .OrderBy(orderByLambda)
                .Skip(pageSize * (pageIndex - 1))
                .Take(pageSize).ToListAsync();
            }
            else
            {
                return await DbSet.Where(conditionsLambda)
                .OrderByDescending(orderByLambda)
                .Skip(pageSize * (pageIndex - 1))
                .Take(pageSize).ToListAsync();
            }
        } 
        #endregion
    }
}
