using FoodDeliverySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliverySystem.Database
{
    public class FoodDeliveryDbContext:DbContext
    {
        public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options) : base(options)
        {

        }

        // Define DbSet properties for each entity
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryDriver> DeliveryDrivers { get; set; }

        // Override the OnModelCreating method to configure relationships, constraints, etc.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CRLHW-RAZADHAS1\\SQLEXPRESS;Database=FoodDeliveryDB;Trusted_Connection=true; MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}
