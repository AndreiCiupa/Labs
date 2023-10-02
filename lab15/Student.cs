using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    //  • Id (unic)
    //  • Nume
    //  • Prenume
    //  • Varsta
    //  • Specializare

    //• Specializarile vor fi
    //  • Informatica
    //  • Litere
    //  • Constructii
    internal class Student
    {
        public Guid Id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public MajorType Major { get; set; }
        public override string ToString() =>
            $"ID: {Id} Nume: {LastName}, Prenume: {FirstName}, Varsta: {Age}, Specializarea: {Major}";

        public Student() 
        {
            Id = Guid.NewGuid();
        }
    }

    enum MajorType
    {
        Informatica, Litere, Constructii
    }
}
