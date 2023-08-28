using lab11.Autovehicule;
namespace lab11.Statii_De_Pompare
{
    class StatieDePompareHibrida : StatieDePompareClasica, IAlimentareHibrida 
    {
        public void AlimentareElectricitate(Autovehicul autovehicul, int cantitateCombustibil)
        {
            if (autovehicul is AutovehiculElectric)
            {
                Console.WriteLine((autovehicul as AutovehiculElectric).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else if (autovehicul is AutovehiculPlugInHybrid)
            {
                Console.WriteLine((autovehicul as AutovehiculPlugInHybrid).GetDescription() + ", cantitate alimentata: " + cantitateCombustibil);
                autovehicul.cantitate += cantitateCombustibil;
            }
            else
            {
                Console.WriteLine("Autovehicul necorespunzator tipului de combustibil.");
            }
        }
    }
}
