using lab10.BonDeCasa;
using lab10.Dispozitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class CasaDeMarcat
    {
        private Seif seif = new Seif();
        private POS pOS = new POS();
        public Dispozitive.Dispozitiv dispozitiv = new Dispozitive.Dispozitiv();
        public void ScanareProdus()
        {

            Console.WriteLine("beep");
            Console.WriteLine("Produs scanat. Doriti sa efectuati plata cash sau prin intermediul unui POS?");
            Console.WriteLine("optiuni raspuns: cash, POS");
            string raspuns = Console.ReadLine();


            Random rnd = new Random();
            var pretProdus = rnd.Next(1, 90000);

            if (raspuns == "cash")
            {
                PlataCash(pretProdus);
            }
            else if (raspuns == "POS")
            {
                pretProdus = rnd.Next(1, dispozitiv.GetSold());
                PlataPOS(pretProdus);
            }
        }
        public void PlataCash(int sumaDePlata)
        {
            seif.DeschideSeif();           
            seif.IntroducereSuma(sumaDePlata);
            seif.InchideSeif();
            seif.EliberareChitanta();

            BonCash(sumaDePlata);
        }
        public void PlataPOS(int sumaDePlata)
        {
            Console.WriteLine("Efetuati plata cu telefon sau card?");
            string raspuns = Console.ReadLine();

            if (raspuns == "telefon")
            {
                pOS.PlataContactless(sumaDePlata, this.dispozitiv);
                BonPOS(sumaDePlata, "card contactless"); //plata cu telefonul e tot un card defapt (?)
            }
            else if (raspuns == "card")
            {
                if (this.dispozitiv is CardClasic)
                {
                    pOS.PlataContactFull(sumaDePlata, this.dispozitiv);
                    BonPOS(sumaDePlata, "card contact-full");
                }
                else if (this.dispozitiv is CardContactless)
                {
                    pOS.PlataContactless(sumaDePlata, this.dispozitiv);
                    BonPOS(sumaDePlata, "card contactless");
                }
            }
        }

        public void BonCash(int sumaDePlata)
        {
            Console.WriteLine("Doriti bonul?");
            Console.WriteLine("optiuni raspuns: da, nu");
            string raspuns = Console.ReadLine();

            if (raspuns == "da")
            {
                BonDeCasa.BonDeCasa bonDeCasa = new BonDeCasa.BonDeCasa(sumaDePlata, "cash");
                bonDeCasa.Afisare();
            }
        }

        public void BonPOS(int sumaDePlata, string metodaPlata)
        {
            Console.WriteLine("Doriti bonul?");
            Console.WriteLine("optiuni raspuns: da, nu");
            string raspuns = Console.ReadLine();

            if (raspuns == "da")
            {
                BonDeCasa.BonDeCasa bonDeCasa = new BonDeCasa.BonDeCasa(sumaDePlata, metodaPlata);
                bonDeCasa.Afisare();
            }
        }

    }
}
