using lab11.Autovehicule;
using lab11.Camion;

namespace lab11.Statii_De_Pompare
{
    class StatieDePompareClasica : IAlimentareClasica
    {
        public void AlimentareBenzina(Autovehicul autovehicul, int cantitateCombustibil)
        {
            if (autovehicul is AutovehiculBenzina)
            {
                Console.WriteLine((autovehicul as AutovehiculBenzina).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil; 
            }
            else if (autovehicul is AutovehiculPlugInHybrid)
            {
                Console.WriteLine((autovehicul as AutovehiculPlugInHybrid).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else if (autovehicul is AutovehiculGPL)
            {
                Console.WriteLine((autovehicul as AutovehiculGPL).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else if (autovehicul is Cisterna)
            {
                if ((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Benzina)
                {
                    (autovehicul as Cisterna).cantitate += cantitateCombustibil;
                    Console.WriteLine((autovehicul as Cisterna).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                }
                else if ((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Diesel)
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
                Console.WriteLine((autovehicul as AutovehiculDiesel).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else if (autovehicul is Cisterna)
            {
                if ((autovehicul as Cisterna).tipAutovehicul == TipAutovehicul.Diesel)
                {
                    (autovehicul as Cisterna).cantitate += cantitateCombustibil;
                    Console.WriteLine((autovehicul as Cisterna).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
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
                Console.WriteLine((autovehicul as AutovehiculGPL).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else
            {
                Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
            }
        }
    }
}
