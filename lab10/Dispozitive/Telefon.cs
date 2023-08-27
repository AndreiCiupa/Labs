using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Dispozitive
{
    class Telefon : Dispozitiv, IPlataContactless
    {
        public void ApropieCard()
        {
            Console.WriteLine("Dispozitivul a fost apropiat.");
        }

        public void EfectueazaPlata(int suma)
        {
            base.soldCurent -= suma;
            Console.WriteLine("Plata efetuata.");
        }
    }
}
