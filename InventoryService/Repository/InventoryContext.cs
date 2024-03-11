using InventoryService.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Repository
{
    public class InventoryContext(DbContextOptions options) :DbContext (options)
    {
        public DbSet<OrderRequests> OrderRequests { get; set; }
    }
}
