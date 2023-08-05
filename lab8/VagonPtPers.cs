using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class VagonPtPers : Vagon
    {
        private int numarLocuri;

        public VagonPtPers(int masa, int anFabricatie, int numarLocuri):base(masa, anFabricatie)
        {
            this.numarLocuri = numarLocuri;
            base.tipVagon = TipVagon.PentruPersoane;
        }

        public int GetNumarLocuri() { return this.numarLocuri; }

        public void InchidereUsi()
        {
            Console.WriteLine("Usile s-au inchis.");
        }

        public void DeschidereUsi()
        {
            Console.WriteLine("Usile s-au deschis.");
        }
        
    }
}
