namespace lab11.Statii_De_Pompare
{
    interface IAlimentareClasica
    {
        public void AlimentareBenzina(Autovehicule.Autovehicul autovehicul, int cantitateCombustibil);
        public void AlimentareDiesel(Autovehicule.Autovehicul autovehicul, int cantitateCombustibil);
        public void AlimentareGPL(Autovehicule.Autovehicul autovehicul, int cantitateCombustibil);
    }
}
