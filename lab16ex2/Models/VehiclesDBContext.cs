using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex2.Models
{
    internal class VehiclesDBContext : DbContext
    {
        public DbSet<Autovehicul> Autovehicule { get; set; }
        public DbSet<Producator> Producator { get; set; }
        public VehiclesDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\lab1ex1\lab16ex2\VehiclesDB.mdf;Integrated Security=True");
        }
    }
}
