using Microsoft.EntityFrameworkCore;

/// <summary>
/// Migrations Tools -> NuGet Package Manager -> Package Manager Console
/// Add-Migrations [Name]
/// Update-Database
/// Remove-Migration - Last migration
/// </summary>

namespace MediumGS.Data.Concrete
{
    public class TestContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}