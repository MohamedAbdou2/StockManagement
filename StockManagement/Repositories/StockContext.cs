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
            modelBuilder.Entity<Item>().HasData(
               new Item { Id = -1, Name = "iPhone 13", Price = 999, Description = "Apple iPhone 13 with 128GB storage" },
               new Item { Id = -2, Name = "Samsung Galaxy S21", Price = 799, Description = "Samsung Galaxy S21 with 128GB storage" },
               new Item { Id = -3, Name = "Google Pixel 6", Price = 599, Description = "Google Pixel 6 with 128GB storage" },
               new Item { Id = -4, Name = "OnePlus 9", Price = 729, Description = "OnePlus 9 with 128GB storage" },
               new Item { Id = -5, Name = "Sony Xperia 5 II", Price = 949, Description = "Sony Xperia 5 II with 128GB storage" },
               new Item { Id = -6, Name = "Xiaomi Mi 11", Price = 749, Description = "Xiaomi Mi 11 with 128GB storage" },
               new Item { Id = -7, Name = "Oppo Find X3 Pro", Price = 1149, Description = "Oppo Find X3 Pro with 256GB storage" },
               new Item { Id = -8, Name = "Nokia 8.3 5G", Price = 699, Description = "Nokia 8.3 5G with 128GB storage" },
               new Item { Id = -9, Name = "Asus ROG Phone 5", Price = 999, Description = "Asus ROG Phone 5 with 256GB storage" },
               new Item { Id = -10, Name = "Huawei P40 Pro", Price = 899, Description = "Huawei P40 Pro with 256GB storage" }
           );


            modelBuilder.Entity<Store>().HasData(
                new Store { Id = -1, Name = "Tech World", Address = "123 Tech Street" },
                new Store { Id = -2, Name = "Gadget Hub", Address = "456 Gadget Avenue" },
                new Store { Id = -3, Name = "Phone Plaza", Address = "789 Phone Road" },
                new Store { Id = -4, Name = "Mobile Center", Address = "101 Mobile Lane" },
                new Store { Id = -5, Name = "Electro Store", Address = "202 Electro Boulevard" },
                new Store { Id = -6, Name = "Device Depot", Address = "303 Device Drive" },
                new Store { Id = -7, Name = "Smartphone Shop", Address = "404 Smartphone Way" },
                new Store { Id = -8, Name = "Techie Corner", Address = "505 Techie Circle" },
                new Store { Id = -9, Name = "Gizmo Place", Address = "606 Gizmo Place" },
                new Store { Id = -10, Name = "Digital Market", Address = "707 Digital Street" }
            );




            base.OnModelCreating(modelBuilder);
        }

    }
}
