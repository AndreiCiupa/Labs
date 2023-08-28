namespace lab10.Dispozitive
{
    class Dispozitiv
    {
        protected int soldCurent;

        public void AdaugaBani(int sumaBani)
        {
            this.soldCurent += sumaBani;
        }

        public int GetSold()
        {
            return this.soldCurent;
        }
    }
}
