using studentManagmentSystem.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace studentManagmentSystem.DataAccess.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.CourseId);
            builder.Property(c=>c.CourseName)
                .IsRequired()
                .HasMaxLength(20);
               

        }
    }
}
