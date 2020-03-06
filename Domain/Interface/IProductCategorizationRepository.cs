using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NationalDay_DDD.Domain.Interface
{
    public interface IProductCategorizationRepository : IRepository<ProductCategorization>
    {
        // 获取指定分类下的所有商品信息
        Task<List<Product>> GetProductsForCategory(Category category);

        /// <summary>
        /// 获取指定分类下的所有商品信息,以分页的方式
        /// </summary>
        /// <param name="category">指定的商品分类</param>
        /// <param name="pageNumber">所请求的分页页码</param>
        /// <param name="pageSize">所请求的页大小</param>
        /// <returns>指定分类下的某页的商品信息</returns>
        Task<List<Product>> GetProductsForCategoryWithPagination<S>(int pageSize, int pageIndex, bool isAsc, Expression<Func<Category, bool>> conditionsLambda, Expression<Func<Category, S>> orderByLambda);

        /// <summary>
        /// 获取商品所属的商品分类。
        /// </summary>
        /// <param name="product">商品信息。</param>
        /// <returns>商品分类。</returns>
        Task<Category> GetCategoryForProduct(Product product);
    }
}
