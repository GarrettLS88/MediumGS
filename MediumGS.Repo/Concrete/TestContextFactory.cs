using MediumGS.Repo.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MediumGS.Data.Concrete
{
    public class TestContextFactory : IDesignTimeDbContextFactory<TestContext>
    {
        public TestContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestContext>();
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=mediumgs_test;Uid=root;Pwd='Narsh1pgh0st;';persistsecurityinfo=True;");

            return new TestContext(optionsBuilder.Options);
        }
    }
}
