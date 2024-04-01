namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduSop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            var manger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));
            var user = new ApplicationUser()
            {
                UserName = "HoangAn",
                Email = "roadtofinishwebsite@gmail.com",
                EmailConfirmed = true,
                FullName = "Công nghệ"
            };
            manger.Create(user, "12345$");

            if(!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin"});
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manger.FindByEmail("roadtofinishwebsite@gmail.com");
            manger.AddToRoles(adminUser.Id, new string[] {"Admin", "User" });
        }
    }
}
