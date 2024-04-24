using AutoMapper;
using TeduShop.Web.Models;
using TeduSop.Model.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguation
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Post, PostViewModel>();

            Mapper.CreateMap<Product,ProductViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            Mapper.CreateMap<Footer, FooterViewModel>();
            Mapper.CreateMap<Slide, SlideViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();

        }
    }
}