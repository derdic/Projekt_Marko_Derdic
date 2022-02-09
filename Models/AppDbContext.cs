using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Adidas> Adidass { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Adidas>().HasData(
                new Adidas
                {
                    Id = 1,
                    Name = "Boksačke rukavice",
                    Size = "10oz",
                    Price = 705
                });
        }

    }
}
