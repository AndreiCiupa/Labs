using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18.Models
{
    internal class Cheie
    {
        public int Id { get; set; }
        public Guid CodAcces { get; set; } = Guid.NewGuid();
    }
}
