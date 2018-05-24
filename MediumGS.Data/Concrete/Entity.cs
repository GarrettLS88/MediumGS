using MediumGS.Data.Abstract;

namespace MediumGS.Data.Concrete
{
    public class Entity : IEntity, IDeletable
    {
        public int Id { get; set; }
        public bool? Deleted { get; set; }
    }
}
