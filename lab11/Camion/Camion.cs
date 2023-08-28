using lab11.Autovehicule;

namespace lab11.Camion
{
    class Camion
    {
        private string model;
        private int id;
        private TipCombustibil tipCombustibil = new TipCombustibil();
        public AutovehiculDiesel capTractor;
        public Cisterna cisterna;

        public Camion(string model, int id, TipCombustibil tipCombustibil)
        {
            this.model = model;
            this.id = id;
            this.tipCombustibil = tipCombustibil;

            this.capTractor = new AutovehiculDiesel(model, id);
            this.cisterna = new Cisterna(model, id, tipCombustibil);
        }
    }
}
