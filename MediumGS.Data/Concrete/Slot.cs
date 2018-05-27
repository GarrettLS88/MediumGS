namespace MediumGS.Data.Concrete
{
    public class Slot : Entity
    {
        public int PageContentID { get; set; }
        public string Name { get; set; }
        public string Html { get; set; }

        public PageContent PageContent { get; set; }
    }
}
