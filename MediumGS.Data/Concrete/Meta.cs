namespace MediumGS.Data.Concrete
{
    public class Meta : Entity
    {
        public int PageContentID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public PageContent PageContent { get; set; }
    }
}
