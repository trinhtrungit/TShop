﻿using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline> { }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}