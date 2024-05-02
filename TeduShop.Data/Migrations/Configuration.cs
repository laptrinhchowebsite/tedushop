namespace TeduShop.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Common;
    using TeduSop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProductCategorySample(context);
            CreateSlide(context);
            CreatePage(context);
            CreateContactDetail(context);
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

        private void CreatePage(TeduShopDbContext context)
        {
            if (context.Pages.Count() == 0)
            {
                var page = new Page()
                {
                    Name = "Giới thiệu",
                    Alias = "gioi-thieu",
                    Content = @"Nước hoa giá rẻ dành cho cả nam nữ với hương thơm tươi mới và ấn tượng. New Perfume 10ml mang hương thơm cây cỏ tự nhiên kết hợp với hương hoa nồng nàn, đặc tả những nốt hương gần gũi, tinh tế, tự tin và lôi cuốn. Hương đầu là nhóm quýt hồng, bạc hà, táo xanh, chanh. Tầng hương giữa xen lẫn hoa phong lan, quả mận, hoa diên vĩ, hổ phách. Lớp hương cuối là xạ hương, cây hoắc hương, cỏ Vetiver, địa y, tuyết tùng.
                            Dung tích 10ml, độ tỏa hương: 3m, chai nước hoa dạng xịt. Độ lưu hương hơn 6 giờ trên da và 24 giờ trên vải. Phù hợp cho làm việc, công sở, gặp gỡ và hẹn hò. Tinh dầu nước hoa nguyên chất từ Paris, Pháp.",
                    Status = true
                };
                context.Pages.Add(page);
                context.SaveChanges();
            }
        }

        private void CreateContactDetail(TeduShopDbContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                var contactDetail = new ContactDetail()
                {
                    Name = "Shop thời trang TEDU",
                    Address = "Ngõ 77 Xuân La",
                    Lat = 21.0633645,
                    Lng = 105.8053274,
                    Phone = "0954323222",
                    Website = "http://tedu.com.vn",
                    Other = "",
                    Status = true
                };
                context.ContactDetails.Add(contactDetail);
                context.SaveChanges();
            }
        }
    }
}