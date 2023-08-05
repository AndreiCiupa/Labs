using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Vagon
    {
        private int masa;
        private int anFabricatie;
        protected TipVagon tipVagon;

        public Vagon(int masa, int anFabricatie)
        {
            this.masa = masa;
            this.anFabricatie = anFabricatie;
        }

        public TipVagon GetTipVagon() {  return this.tipVagon; }
    }
}
