namespace lab11.Autovehicule
{
    class Autovehicul
    {
        protected string model;
        protected int id;
        public int cantitate;
        public TipAutovehicul tipAutovehicul;
        protected List<TipCombustibil> tipCombustibili = new List<TipCombustibil>();

        public Autovehicul(string model, int id)
        {
            this.model = model;
            this.id = id;
        }

        public virtual string GetDescription()
        {
            return "model: " + model + ", id: " + id;
        }
    }
}
