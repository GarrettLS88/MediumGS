using MediumGS.Data.Abstract;

namespace MediumGS.Data.Concrete
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(TestContext context)
            : base(context)
        {
        }
    }
}
