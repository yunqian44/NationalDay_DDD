using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NationalDay_DDD.Domain.Interface
{
    public interface IProductRepository: IRepository<Product>
    {
        #region 01,Get new product recommendations basd on Conditions+Task<List<Product>> GetNewProducts<S>(int pageSize, int pageIndex, bool isAsc, Expression<Func<Product, bool>> conditionsLambda, Expression<Func<Product, S>> orderByLambda)
        /// <summary>
        /// Get new product recommendations basd on Conditions
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="pageSize">page size</param>
        /// <param name="pageIndex">pageIndex</param>
        /// <param name="isAsc">isAsc</param>
        /// <param name="conditionsLambda">conditions</param>
        /// <param name="orderByLambda">orderBy</param>
        /// <returns></returns>
        Task<List<Product>> GetNewProducts<S>(int pageSize, int pageIndex, bool isAsc, Expression<Func<Product, bool>> conditionsLambda, Expression<Func<Product, S>> orderByLambda);
        #endregion


    }
}
