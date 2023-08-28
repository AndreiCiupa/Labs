namespace lab10.BonDeCasa
{
    class BonDeCasa
    {
        private int suma;
        private string metodaDePlata;

        public BonDeCasa(int suma, string metodaDePlata)
        {
            this.suma = suma;
            this.metodaDePlata = metodaDePlata;
        }

        public string GetBonDeCasa()
        {
            //return $"Achitat: {suma} lei, metoda de plata: {metodaDePlata}";
            return "Achitat: " + this.suma + " lei, metoda de plata: " + this.metodaDePlata;
        }
    }
}
