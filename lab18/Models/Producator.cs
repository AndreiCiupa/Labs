using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18.Models
{
    internal class Producator
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public List<Autovehicul> Autovehicule { get; set; } = new List<Autovehicul>();
    }
}
