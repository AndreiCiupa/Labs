using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17.Models
{
    internal class Manufacturer
    {
        public Manufacturer()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CUI { get; set; }
        public List<Product> Products { get; set; }
        public override string ToString() =>
            $"Name: {Name}, Address: {Address}, CUI: {CUI}";
    }
}
