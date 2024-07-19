using Microsoft.EntityFrameworkCore;
using RingoMediaTask.Models;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Reminder> Reminders => Set<Reminder>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
