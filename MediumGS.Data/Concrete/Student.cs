using System;
using System.Collections.Generic;

namespace MediumGS.Data.Concrete
{
    public class Student : Entity
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
