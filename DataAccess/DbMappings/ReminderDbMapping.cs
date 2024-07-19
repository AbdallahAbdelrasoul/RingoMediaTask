using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RingoMediaTask.Models;

namespace RingoMediaTask.DataAccess.DbMappings
{
    public class ReminderDbMapping : IEntityTypeConfiguration<Reminder>
    {
        public void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.ToTable("Reminders").HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired(true).HasMaxLength(256);
            builder.Property(x => x.DateTime).IsRequired(true);
        }
    }
}
