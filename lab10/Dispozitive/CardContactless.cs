namespace lab10.Dispozitive
{
    class CardContactless : Dispozitiv, IPlataContactless, IPlataContactFull
    {
        public void ApropieCard()
        {
            Console.WriteLine("Cardul a fost apropiat.");
        }

        public void EfectueazaPlata(int suma)
        {
            base.soldCurent -= suma;
            Console.WriteLine("Plata efetuata.");
        }

        public void IntroduCard()
        {
            Console.WriteLine("Cardul a fost introdus.");
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Cardul a fost extras.");
        }
    }
}
