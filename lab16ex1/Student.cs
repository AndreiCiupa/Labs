using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex1
{
    internal class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public MajorType Major { get; set; }
        public override string ToString() =>
            $"ID: {Id} Nume: {LastName}, Prenume: {FirstName}, Varsta: {Age}, Specializarea: {Major}";
    }
    enum MajorType
    {
        Informatica, Litere, Constructii
    }
}
