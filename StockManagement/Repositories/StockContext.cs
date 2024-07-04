using Microsoft.EntityFrameworkCore;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class StockContext : DbContext
    {
        public StockContext()
        {

        }

        public StockContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<StoreItem> StoreItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreItem>().HasKey(si => new { si.ItemId, si.StoreId });
            base.OnModelCreating(modelBuilder);
        }

    }
}
