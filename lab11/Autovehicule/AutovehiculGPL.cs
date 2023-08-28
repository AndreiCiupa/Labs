namespace lab11.Autovehicule
{
    internal class AutovehiculGPL : Autovehicul
    {
        public AutovehiculGPL(string model, int id) : base(model, id)
        {
            this.tipAutovehicul = TipAutovehicul.GPL;
            this.tipCombustibili.Add(TipCombustibil.Benzina);
            this.tipCombustibili.Add(TipCombustibil.GPL);
        }
        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }
    }
}

