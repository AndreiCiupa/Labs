using lab11.Autovehicule;
using lab11.Statii_De_Pompare;

namespace lab11.Camion
{
    class Cisterna : Autovehicul, IAlimentareClasica
    {
        //public int cantitateCombustibil;
        public TipCombustibil tipCombustibil = new TipCombustibil();

        public Cisterna(string model, int id, TipCombustibil tipCombustibil) : base(model, id)
        {
            if(tipCombustibil == TipCombustibil.Benzina)
            {
                this.tipAutovehicul = TipAutovehicul.Benzina;
                this.tipCombustibil = TipCombustibil.Benzina;
            }
            else if (tipCombustibil == TipCombustibil.Diesel)
            {
                this.tipAutovehicul = TipAutovehicul.Diesel;
                this.tipCombustibil = TipCombustibil.Diesel;
            }
        }

        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }

        public void AlimentareBenzina(Autovehicul autovehicul, int cantitateCombustibil)
        {
            if (autovehicul is AutovehiculBenzina)
            {
                autovehicul.cantitate += cantitateCombustibil;
                Console.WriteLine((autovehicul as AutovehiculBenzina).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil + ", capacitate autovehicul: " + autovehicul.cantitate);
            }
            else if (autovehicul is AutovehiculPlugInHybrid)
            {
                autovehicul.cantitate += cantitateCombustibil;
                Console.WriteLine((autovehicul as AutovehiculPlugInHybrid).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil + ", capacitate autovehicul: " + autovehicul.cantitate);
            }
            else if (autovehicul is AutovehiculGPL)
            {
                autovehicul.cantitate += cantitateCombustibil;
                Console.WriteLine((autovehicul as AutovehiculGPL).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil + ", capacitate autovehicul: " + autovehicul.cantitate);
            }
            else if (autovehicul is Cisterna)
            {
                if((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Benzina)
                {
                    (autovehicul as Cisterna).cantitate += cantitateCombustibil;
                }
                else if((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Diesel)
                {
                    Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
                }
            }
            else
            {
                Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
            }
        }
        public void AlimentareDiesel(Autovehicul autovehicul, int cantitateCombustibil)
        {
            if (autovehicul is AutovehiculDiesel)
            {
                autovehicul.cantitate += cantitateCombustibil;
                Console.WriteLine((autovehicul as AutovehiculDiesel).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil + ", capacitate autovehicul: " + autovehicul.cantitate);
            }
            else if (autovehicul is Cisterna)
            {
                if ((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Diesel)
                {
                    (autovehicul as Cisterna).cantitate += cantitateCombustibil;
                }
                else if ((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Benzina)
                {
                    Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
                }
            }
            else
            {
                Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
            }
        }
        public void AlimentareGPL(Autovehicul autovehicul, int cantitateCombustibil)
        {
            if (autovehicul is AutovehiculGPL)
            {
                autovehicul.cantitate += cantitateCombustibil;
                Console.WriteLine((autovehicul as AutovehiculGPL).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil + ", capacitate autovehicul: " + autovehicul.cantitate);
            }
            else
            {
                Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
            }
        }
    }
}
