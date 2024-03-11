using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.Repository
{
    public class OrderContext(DbContextOptions options) : DbContext (options)
    {
        public DbSet<Cart> Carts { get; set; }
    }
}
