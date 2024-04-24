using TeduShop.Data.Infrastructure;
using TeduSop.Model.Models;


namespace TeduShop.Data.Repositories
{
    public interface IContactDetailRepository : IRepository<ContactDetail>
    { }
    public class ContactDetailRepository : RepositoryBase<ContactDetail>,IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
