namespace TShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TShopDbContext dbContext;
        // define method from interface
        public TShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TShopDbContext());
        }
        // overrid from parent class
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}