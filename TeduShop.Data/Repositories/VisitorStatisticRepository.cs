using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatisticRepository
    { }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}