using Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1
{
    public class RailwayContext : DbContext
    {
        public RailwayContext(DbContextOptions<RailwayContext> options) : base(options) 
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<RailwayRoute> Routes { get; set; }


    }
}