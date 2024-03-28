using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
        : base(dbFactory)
        {
        }
    }
}