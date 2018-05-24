namespace MediumGS.Data.Concrete
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment : Entity
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
