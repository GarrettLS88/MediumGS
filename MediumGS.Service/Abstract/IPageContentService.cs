using MediumGS.Data.Concrete;
using System.Collections.Generic;

namespace MediumGS.Service.Abstract
{
    public interface IPageContentService
    {
        PageContent GetPage(int id);
        IEnumerable<PageContent> GetAllPages();
        void AddPage(PageContent page);
        void UpdatePage(PageContent page);
        void DeletePage(int id);
    }
}
