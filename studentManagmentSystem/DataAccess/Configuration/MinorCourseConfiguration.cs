using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentManagmentSystem.Entity;

namespace studentManagmentSystem.DataAccess.Configuration
{
    public class MinorCourseConfiguration : IEntityTypeConfiguration<MinorCourse>
    {
        public void Configure(EntityTypeBuilder<MinorCourse> builder)
        {
            builder.HasKey(mc =>new { mc.StudentId, mc.CourseId});
            builder.HasOne(mc => mc.Student)
                .WithMany(c => c.MinorCourses)
                .HasForeignKey(s=>s.StudentId);

            builder.HasOne(mc => mc.Course)
               .WithMany(c => c.MinorCourses)
               .HasForeignKey(s => s.CourseId);
        }
    }
}
