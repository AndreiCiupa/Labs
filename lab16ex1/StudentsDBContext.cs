using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex1
{
    internal class StudentsDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentsDBContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\lab1ex1\lab16ex1\StudentsDB.mdf;Integrated Security=True");
        }
    }
}
