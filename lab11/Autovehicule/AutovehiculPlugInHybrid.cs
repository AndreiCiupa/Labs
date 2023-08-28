namespace lab11.Autovehicule
{
    internal class AutovehiculPlugInHybrid : Autovehicul
    {
        public AutovehiculPlugInHybrid(string model, int id) : base(model, id)
        {
            this.tipAutovehicul = TipAutovehicul.PlugInHybrid;
            this.tipCombustibili.Add(TipCombustibil.Benzina);
            this.tipCombustibili.Add(TipCombustibil.Electricitate);
        }
        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }
    }
}
