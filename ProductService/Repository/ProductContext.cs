using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Repository
{
    public class ProductContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

    }
}
