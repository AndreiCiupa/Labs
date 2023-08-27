using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.BonDeCasa
{
    static class BonDeCasaExtensie
    {
        public static void Afisare(this BonDeCasa bon)
        {
            Console.WriteLine(bon.GetBonDeCasa());
        }
    }
}
