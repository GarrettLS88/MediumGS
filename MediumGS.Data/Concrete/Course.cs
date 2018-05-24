using MediumGS.Data.Abstract;
using System.Collections.Generic;

namespace MediumGS.Data.Concrete
{
    public class Course : Entity
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
