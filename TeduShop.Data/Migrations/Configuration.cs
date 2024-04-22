namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Common;
    using TeduSop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProductCategorySample(context);
            CreateSlide(context);

        }
        private void CreateUser(TeduShop.Data.TeduShopDbContext context)
        {
            //var manger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));
            //var user = new ApplicationUser()
            //{
            //    UserName = "HoangAn",
            //    Email = "roadtofinishwebsite@gmail.com",
            //    EmailConfirmed = true,
            //    FullName = "Công nghệ"
            //};
            //manger.Create(user, "12345$");

            //if(!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin"});
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}
            //var adminUser = manger.FindByEmail("roadtofinishwebsite@gmail.com");
            //manger.AddToRoles(adminUser.Id, new string[] {"Admin", "User" });
        }
        private void CreateProductCategorySample(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listproductCategory = new List<ProductCategory>()
                {
                    new ProductCategory{Name="Điện lạnh",Alias="dien-lanh",Status=true},
                    new ProductCategory{Name="Viễn thông",Alias="vien-thong",Status=true},
                    new ProductCategory{Name="Đồ gia dụng",Alias="do-gia-dung",Status=true},
                    new ProductCategory{Name="Mỹ phẩm",Alias="my-pham",Status=true},

                };
                context.ProductCategories.AddRange(listproductCategory);
                context.SaveChanges();
            }

        }
        private void CreateFooter(TeduShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }
        private void CreateSlide(TeduShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {
                        Name="Slide 1",
                        DisplayOrder=1,
                        Status = true,
                        Url="#",Image="/Assets/client/images/bag.jpg"
                    ,Content="<h2>FLAT 50% 0FF</h2><label>FOR ALL PURCHASE <b>VALUE</b></label><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p><span class='on-get'>GET NOW</span>"},
                    new Slide() {
                        Name="Slide 2",
                        DisplayOrder=2,
                        Status = true,
                        Url="#",Image="/Assets/client/images/bag.jpg"
                    ,Content="<h2>FLAT 50% 0FF</h2><label>FOR ALL PURCHASE <b>VALUE</b></label><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >< span class='on-get'>GET NOW</span>"}


                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }

    }
}
