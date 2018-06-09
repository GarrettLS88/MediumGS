namespace MediumGS.Data.Concrete
{
    public class Schema : Entity
    {
        public int PageContentID { get; set; }
        public string Name { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public PageContent PageContent { get; set; }
    }
}
