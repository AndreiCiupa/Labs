using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17.Models
{
    internal class Label
    {
        public Label() 
        {
            Barcode = new Guid();
        }
        public int Id { get; set; }
        public Guid Barcode { get; set; }
        public double Price { get; set; }
    }
}
