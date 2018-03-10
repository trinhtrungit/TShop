using System.Data.Entity;
using TShop.Model.Models;

namespace TShop.Data
{
    // Suffix is DbContext, inheritance from DbContext.
    public class TShopDbContext : DbContext
    {
        // Fill connection name
        public TShopDbContext()
            : base("TShopConnection")
        {
            // Config to avoid auto include childrens when including parent.
            this.Configuration.LazyLoadingEnabled = false;
        }

        // Need to reference Model from here
        public DbSet<Footer> Footers { set; get; }

        public DbSet<Page> Pages { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<GroupMenu> GroupMenus { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<Slider> Sliders { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<DetailOrder> DetailOrders { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        // Overwrite onModelCreating method of DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}