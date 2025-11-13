using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentManagmentSystem.Entity;
namespace studentManagmentSystem.DataAccess.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DepartmentId);
            builder.Property(d=>d.DepartmentName).IsRequired().HasMaxLength(20);

        }
    }
}
