using MediumGS.Data.Concrete;
using MediumGS.Repo.Abstract;
using MediumGS.Service.Abstract;
using System.Collections.Generic;

namespace MediumGS.Service.Concrete
{
    public class PageContentService : IPageContentService
    {
        private readonly IRepository<PageContent> _pageRepository;

        public PageContentService(IRepository<PageContent> pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public PageContent GetPage(int id)
        {
            return _pageRepository.GetSingle(id);
        }
        
        public IEnumerable<PageContent> GetAllPages()
        {
            return _pageRepository.GetAll();
        }

        public void AddPage(PageContent page)
        {
            _pageRepository.Insert(page);
        }

        public void UpdatePage(PageContent page)
        {
            _pageRepository.Update(page);
        }

        public void DeletePage(int id)
        {
            _pageRepository.Delete(id);
        }
    }
}
