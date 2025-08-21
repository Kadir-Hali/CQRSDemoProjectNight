using CQRSDemoProjectNight.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.Context
{
    public class DemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Initial Catalog = DemoCQRSNightDb; Integrated Security = true; Trust Server Certificate = true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
