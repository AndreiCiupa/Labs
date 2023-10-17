using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Category Category { get; set; }
        public Label Label { get; set; }
        public override string ToString() => 
            $"Name: {Name}, Stock: {Stock}, Manufacturer: {Manufacturer.Name}, Category: {Category.Name}, Price: {Label.Price}";
    }
}
