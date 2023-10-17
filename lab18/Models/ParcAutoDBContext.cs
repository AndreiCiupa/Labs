using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18.Models
{
    internal class ParcAutoDBContext : DbContext
    {
        public DbSet<Autovehicul> Autovehicule { get; set; }
        public DbSet<Producator> Producatori { get; set; }
        public DbSet<Cheie> Chei { get; set; }
        public DbSet<CarteTehnica> CartiTehnice { get; set; }
        public ParcAutoDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\lab1ex1\lab18\ParcAuto.mdf;Integrated Security=True");
        }
    }
}
