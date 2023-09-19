using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Card
    {
        public Guid idCard { get; set; }

        public void IntroduCard()
        {
            Console.WriteLine("Card introdus.");
        }

        public Guid GetCradData()
        {
            return idCard;
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Card extras.");
        }
    }
}
