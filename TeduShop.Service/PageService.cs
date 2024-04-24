using System;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduSop.Model.Models;
using System.Linq;

namespace TeduShop.Service
{
    public interface IPageService
    {
        Page GetByAlias(string alias);
    }

    public class PageService : IPageService
    {
        private IPageRepository _pageRepository;
        private IUnitOfWork _unitOfWork;

        public PageService(IPageRepository pageRepository,IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x=>x.Alias == alias);
 
        }
    }
}