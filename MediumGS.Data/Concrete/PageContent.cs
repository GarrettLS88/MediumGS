using System.Collections.Generic;

namespace MediumGS.Data.Concrete
{
    public class PageContent : Entity
    {
        public string Name { get; set; }

        public ICollection<Slot> Slots { get; set; }
        public ICollection<Meta> Metas { get; set; }
        public ICollection<Schema> Schemas { get; set; }
    }
}
