using studentManagmentSystem.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace studentManagmentSystem.DataAccess.Configuration
{
    public class MajorCourseConfiguration : IEntityTypeConfiguration<MajorCourse>
    {
        void IEntityTypeConfiguration<MajorCourse>.Configure(EntityTypeBuilder<MajorCourse> builder)
        {
            builder.HasKey(mj =>new  { mj.StudentId,mj.CourseId});
            builder.HasOne(mc => mc.Student)
                          .WithMany(s => s.MajorCourses)
                          .HasForeignKey(mc => mc.StudentId);
            builder.HasOne(mc => mc.Course)
               .WithMany(c => c.MajorCourses)
               .HasForeignKey(mc => mc.CourseId);


        }
    }
}
