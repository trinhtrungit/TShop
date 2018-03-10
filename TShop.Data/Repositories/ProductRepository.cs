using System.Collections.Generic;
using System.Linq;
using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByAlias(string alias);
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
    }
}