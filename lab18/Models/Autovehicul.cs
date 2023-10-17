using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18.Models
{
    internal class Autovehicul
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public Producator Producator { get; set; }
        public List<Cheie> Chei { get; set; } = new List<Cheie>();
        public CarteTehnica CarteTehnica { get; set; }
    }
}
