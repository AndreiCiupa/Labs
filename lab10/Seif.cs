namespace lab10
{
    class Seif
    {
        private int sumaSeif;
        public void DeschideSeif()
        {
            Console.WriteLine("Seiful a fost deschis.");
        }
        public void IntroducereSuma(int sumaDePlata)
        {
            this.sumaSeif += sumaDePlata;
            Console.WriteLine("Suma a fost introdusa in seif.");
        }
        public void InchideSeif()
        {
            Console.WriteLine("Seiful a fost inchis.");
        }
        public void EliberareChitanta()
        {
            Console.WriteLine("Chitanta a fost eliberata");
        }
    }
}
