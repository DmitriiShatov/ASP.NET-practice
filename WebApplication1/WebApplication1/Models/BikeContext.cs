using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BikeContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BikeContext(DbContextOptions<BikeContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
