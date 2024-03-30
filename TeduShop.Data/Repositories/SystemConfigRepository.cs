using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISystemConfigRepository
    { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}