using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentManagmentSystem.Entity;


namespace studentManagmentSystem.DataAccess.Configuration
{
    public class StudnetConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(s=>s.StudentId);
            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(s => s.LastName) 
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(s => s.DateOfBirth)
                .IsRequired()
                .HasColumnType("Date");
            builder.Property(s => s.DepartmentId).IsRequired();
            builder.Property(s => s.GithubUrl);
            builder.Property(s=>s.ImageUrl);



        }
    }
}
