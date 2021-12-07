using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U1_PROYECTO_ULISES_Y_GABRIEL_V2.Models;

namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UlisesGabriel; Integrated Security=true").EnableSensitiveDataLogging(true);
        }
        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }

    }

}
