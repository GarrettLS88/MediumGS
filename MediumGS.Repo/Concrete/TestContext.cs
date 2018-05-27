using MediumGS.Data.Concrete;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Migrations Tools -> NuGet Package Manager -> Package Manager Console
/// Add-Migrations [Name]
/// Update-Database
/// Remove-Migration - Last migration
/// </summary>

namespace MediumGS.Repo.Concrete
{
    public class TestContext : DbContext
    {
        public DbSet<PageContent> PageContents { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Meta> Metas { get; set; }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PageContent>().ToTable("PageContent");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<Meta>().ToTable("Meta");
        }
    }
}