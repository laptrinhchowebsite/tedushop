using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPageRepository
    { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}