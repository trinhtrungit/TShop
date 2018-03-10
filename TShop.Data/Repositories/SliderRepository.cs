﻿using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface ISliderRepository : IRepository<Slider> { }

    public class SliderRepository : RepositoryBase<Slider>, ISliderRepository
    {
        public SliderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}