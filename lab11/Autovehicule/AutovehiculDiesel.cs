namespace lab11.Autovehicule
{
    class AutovehiculDiesel : Autovehicul
    {
        public AutovehiculDiesel(string model, int id) : base(model, id)
        {
            this.tipAutovehicul = TipAutovehicul.Diesel;
            this.tipCombustibili.Add(TipCombustibil.Diesel);
        }
        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }
    }
}