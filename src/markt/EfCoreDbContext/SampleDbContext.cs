using markt.Entities;
using Microsoft.EntityFrameworkCore;

namespace markt.EfCoreDbContext
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions options) 
            : base(options)
        { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItems>()
                .HasOne(p => p.Order)
                .WithMany(b => b.OrderItems)
                .HasForeignKey(c => c.OrderId);
        }
    }
}