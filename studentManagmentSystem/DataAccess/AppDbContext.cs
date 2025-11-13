using Microsoft.EntityFrameworkCore;
using studentManagmentSystem.Entity;

namespace studentManagmentSystem.DataAccess
{
    public class AppDbContext:Microsoft.EntityFrameworkCore.DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

    }
}
