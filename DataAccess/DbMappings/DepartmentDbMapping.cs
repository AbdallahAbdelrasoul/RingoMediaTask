using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RingoMediaTask.Models;

namespace RingoMediaTask.DataAccess.DbMappings
{
    public class DepartmentDbMapping : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments").HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(256);
            builder.Property(x => x.Logo).IsRequired(true).HasMaxLength(256);

            builder.Property(x => x.ParentId).IsRequired(false);
            builder.HasOne(x => x.Parent).WithMany().HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
