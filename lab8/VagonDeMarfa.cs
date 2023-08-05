using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class VagonDeMarfa : Vagon
    {
        private int capacitateTone;
        private TipMarfa tipMarfa;

        public VagonDeMarfa(int masa, int anFabricatie, int capacitateTone, TipMarfa tipMarfa):base(masa, anFabricatie)
        {
            this.capacitateTone = capacitateTone;
            base.tipVagon = TipVagon.DeMarfa;
            this.tipMarfa = tipMarfa;
        }
        public TipMarfa GetTipMarfa() { return this.tipMarfa; }
        public int GetCapacitateTone() { return this.capacitateTone; }
    }
}
