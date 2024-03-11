using CheckoutService.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckoutService.Repository
{
    public class CheckoutContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<OrderStatus> OrderStatuses { get; set; }

    }
}
