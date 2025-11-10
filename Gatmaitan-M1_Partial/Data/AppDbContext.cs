using Gatmaitan_M1_Partial.Models;
using Microsoft.EntityFrameworkCore;

namespace Gatmaitan_M1_Partial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipping> Shippings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Item entity
            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Code).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Brand).HasMaxLength(100);
            });

            // Configure Order entity
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ItemCode).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ItemName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.OrderedBy).IsRequired().HasMaxLength(100);
            });

            // Configure Shipping entity
            modelBuilder.Entity<Shipping>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ItemCode).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ItemName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.OrderedBy).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ShippedTo).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Status).HasMaxLength(50);
            });
        }
    }
}
