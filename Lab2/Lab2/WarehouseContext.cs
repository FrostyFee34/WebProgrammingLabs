using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
        }

        public DbSet<WarehouseCell> WarehouseCells { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}