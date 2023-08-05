using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Tren
    {
        private string nume;
        private Locomotiva locomotiva = new Locomotiva();
        private List<VagonDeMarfa> vagoaneMarfa = new List<VagonDeMarfa>();
        private List<VagonPtPers> vagoanePers = new List<VagonPtPers>();
        private List<VagonClasaI> vagoaneClsI = new List<VagonClasaI>();

        public Tren(string nume)
        {
            this.nume = nume;
        }

        public void AdaugaVagonDeMarfa(VagonDeMarfa vagonDeAdaugat)
        {
            this.vagoaneMarfa.Add(vagonDeAdaugat);
        }

        public void AdaugaVagonPtPers(VagonPtPers vagonDeAdaugat)
        {
            this.vagoanePers.Add(vagonDeAdaugat);
        }

        public void AdaugaVagonClasaI(VagonClasaI vagonDeAdaugat)
        {
            this.vagoaneClsI.Add(vagonDeAdaugat);
        }

        public void PleacaDinGara()
        {
            foreach (VagonPtPers vagon in vagoanePers)
            {
                vagon.InchidereUsi();
            }

            foreach (VagonClasaI vagon in vagoaneClsI)
            {
                vagon.InchidereUsi();
            }

            this.locomotiva.Pornire();
        }

        public void OpresteInGara()
        {
            this.locomotiva.Oprire();

            foreach (VagonPtPers vagon in vagoanePers)
            {
                vagon.DeschidereUsi();
            }

            foreach (VagonClasaI vagon in vagoaneClsI)
            {
                vagon.DeschidereUsi();
                vagon.OprireAerCond();
            }
        }

        public int NumarDeLocuri()
        {
            int count = 0;

            foreach(VagonPtPers vagon in vagoanePers)
            {
                count += vagon.GetNumarLocuri();
            }

            foreach (VagonClasaI vagon in vagoaneClsI)
            {
                count += vagon.GetNumarLocuri();
            }

            return count;
        }

        public List<int> SumarMarfa()
        {
            List<int> sumarMarfa = new List<int>();
            int capacCereale = 0;
            int capacCarbuni = 0;
            int capacOtel = 0;

            foreach (VagonDeMarfa vagon in vagoaneMarfa)
            {
                if(vagon.GetTipMarfa() == TipMarfa.cereale)
                {
                    capacCereale += vagon.GetCapacitateTone();
                }

                if (vagon.GetTipMarfa() == TipMarfa.carbuni)
                {
                    capacCarbuni += vagon.GetCapacitateTone();
                }

                if (vagon.GetTipMarfa() == TipMarfa.otel)
                {
                    capacOtel += vagon.GetCapacitateTone();
                }
            }

            sumarMarfa.Add(capacCereale);
            sumarMarfa.Add(capacCarbuni);
            sumarMarfa.Add(capacOtel);

            return sumarMarfa;
        }
    }
}
