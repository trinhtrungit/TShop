using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IGroupMenuRepository : IRepository<GroupMenu> { }

    public class GroupMenuRepository : RepositoryBase<GroupMenu>, IGroupMenuRepository
    {
        public GroupMenuRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}