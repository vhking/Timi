using Microsoft.EntityFrameworkCore;
using Timi.API.Models;

namespace Timi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<WorkParticipation> WorkParticipations { get; set; }
        public DbSet<WorkCategory> WorkCategories { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Project> Projects { get; set; }

        // Try implementing dapper. 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
                   .HasOne(u => u.Sender)
                   .WithMany(m => m.MessageSent)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
                .HasOne(u => u.Recipient)
                .WithMany(m => m.MessageReceived)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}