namespace TShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TShop.Data.TShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TShop.Data.TShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "trungqt",
                Email = "trungqt@gmail.com",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName = "Technology Education"
            };
            // create
            manager.Create(user, "123654$");
            // create role
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            // find base on email
            var adminUser = manager.FindByEmail("trungqt@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}