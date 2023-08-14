using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ContBancar
    {
        protected readonly string nume;
        protected int valoareSold;
        protected string id;
        protected TipContBancar tipContBancar;

        public ContBancar(string nume, int valoareSold)
        {
            this.nume = nume;
            this.valoareSold = valoareSold;

            System.Guid guid = System.Guid.NewGuid();
            this.id = guid.ToString();
        }

        public virtual string GetDescription()
        {
            return this.nume + ", " + this.valoareSold + ", " + this.id;
        }

        public virtual void DepunereBani(int valoareAdaugata)
        {
            this.valoareSold += valoareAdaugata;
            Console.WriteLine("Tranzactie efectuata cu succes.");
        }

        public virtual void ExtragereBani(int valoareExtrasa)
        {

            if(valoareExtrasa > this.valoareSold)
            {
                Console.WriteLine("Tranzactie nereusita. Suma introdusa depaseste soldul curent.");
            }
            else
            {
                this.valoareSold -= valoareExtrasa;
                Console.WriteLine("Tranzactie efectuata cu succes.");
            }
        }
    }
}
