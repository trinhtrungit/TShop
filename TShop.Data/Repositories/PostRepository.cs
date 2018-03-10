using System.Collections.Generic;
using System.Linq;
using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetByAlias(string alias);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetByAlias(string alias)
        {
            return this.DbContext.Posts.Where(n => n.Alias == alias);
        }
    }
}