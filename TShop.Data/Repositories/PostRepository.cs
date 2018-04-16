using System.Collections.Generic;
using System.Linq;
using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetByAlias(string alias);

        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int rowTotals);
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

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int rowTotals)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.Id equals pt.PostId
                        where pt.TagId == tag && p.Status
                        orderby p.CreateDate descending
                        select p;
            rowTotals = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}