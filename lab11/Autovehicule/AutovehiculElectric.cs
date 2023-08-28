namespace lab11.Autovehicule
{
    class AutovehiculElectric : Autovehicul
    {
        public AutovehiculElectric(string model, int id) : base(model, id)
        {
            this.tipAutovehicul = TipAutovehicul.Electrica;
            this.tipCombustibili.Add(TipCombustibil.Electricitate);
        }
        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }
    }
}
