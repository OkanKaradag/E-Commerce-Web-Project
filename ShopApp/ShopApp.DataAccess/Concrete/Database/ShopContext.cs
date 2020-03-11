using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete
{
    public class ShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //You can use another database provider
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=ShopApp;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
