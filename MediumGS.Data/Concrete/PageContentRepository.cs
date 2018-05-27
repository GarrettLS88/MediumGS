using MediumGS.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumGS.Data.Concrete
{
    public class PageContentRepository : Repository<PageContent>, IPageContentRepository
    {
        public PageContentRepository(TestContext context)
            : base(context)
        {
        }
    }
}
