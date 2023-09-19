using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class Angajat
    {
        public string nume { get; set; }
        public Guid id = Guid.Empty;
        public double salary { get; set; }
        public Departamente departament { get; set; } = new Departamente();

        public Angajat(string nume, double salary, Departamente departament)
        {
            this.nume = nume;
            id = Guid.NewGuid();
            this.salary = salary;
            this.departament = departament;
        }

        public Angajat() { }

        public string ToString()
        {
            return "nume: " + this.nume + "\nid: " + this.id + "\nsalariu: " + this.salary + "\nDepartament: " + this.departament;
        }
    }
}
