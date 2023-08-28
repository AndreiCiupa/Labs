namespace lab11.Autovehicule
{
    class AutovehiculBenzina : Autovehicul
    {
        public AutovehiculBenzina(string model,int id) : base(model, id)
        {
            this.tipAutovehicul = TipAutovehicul.Benzina;
            this.tipCombustibili.Add(TipCombustibil.Benzina);
        }
        public override string GetDescription()
        {
            return "model: " + this.model + ", id: " + this.id + ", tip alimentare: " + this.tipAutovehicul;
        }
    }
}
