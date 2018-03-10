using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IDetailOrderRepository : IRepository<DetailOrder> { }

    public class DetailOrderRepository : RepositoryBase<DetailOrder>, IDetailOrderRepository
    {
        public DetailOrderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}