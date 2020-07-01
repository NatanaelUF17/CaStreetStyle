using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaStreetStyle.Models;

namespace CaStreetStyle.CaStreetStyleDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/CaStreetStyleDb.db");
        }
    }
}
