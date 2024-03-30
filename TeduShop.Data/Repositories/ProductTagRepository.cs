using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository
    { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}