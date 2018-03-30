using System.Collections.Generic;
using System.Linq;
using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByAlias(string alias);
        IEnumerable<Product> GetByTagPaging(string tag, int pageIndex, int pageSize, out int rowTotals);
    }

    // inheritance RepositoryBase and implement interface IProductRepository
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        // Implement GetByAlias method
        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.Products.Where(n => n.Alias == alias);
        }

        public IEnumerable<Product> GetByTagPaging(string tag, int pageIndex, int pageSize, out int rowTotals)
        {
            var query = from product in this.DbContext.Products
                        join proTag in this.DbContext.ProductTags
                        on product.Id equals proTag.ProductId
                        where proTag.TagId == tag && product.Status
                        orderby product.CreateDate descending
                        select product;
            rowTotals = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}