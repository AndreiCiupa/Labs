using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Dispozitive
{
    class CardClasic : Dispozitiv, IPlataContactFull
    {
        public void IntroduCard()
        {
            Console.WriteLine("Cardul a fost introdus.");
        }
        public void EfectueazaPlata(int suma)
        {
            base.soldCurent -= suma;
            Console.WriteLine("Plata efetuata.");
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Cardul a fost extras.");
        }
    }
}
