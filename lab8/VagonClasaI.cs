using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class VagonClasaI : VagonPtPers
    {
        public VagonClasaI(int masa, int anFabricatie, int numarLocuri):base(masa, anFabricatie, numarLocuri) 
        {
            base.tipVagon = TipVagon.ClasaIPentruPersoane;
        }
        public void PornireAerCond()
        {
            Console.WriteLine("Aerul conditionat a fost pornit.");
        }
        public void OprireAerCond()
        {
            Console.WriteLine("Aerul conditionat a fost oprit.");
        }
    }
}
