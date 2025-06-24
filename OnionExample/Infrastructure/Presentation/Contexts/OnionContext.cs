using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Contexts
{
    public class OnionContext : DbContext
    {
        public OnionContext(DbContextOptions<OnionContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations for entities
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnionContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
