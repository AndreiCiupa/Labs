using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ContDeEconomii : ContBancar
    {
        protected int rataDobanda;
        public ContDeEconomii(string nume, int valoareSold, int rataDobanda) : base(nume, valoareSold)
        {
            this.rataDobanda = rataDobanda;
            base.tipContBancar = TipContBancar.ContDeEconomii;
        }

        public override string GetDescription()
        {
            return this.nume + ", " + this.tipContBancar + ", " + this.valoareSold + ", " + this.rataDobanda + ", " + this.id;
        }

        public override void DepunereBani(int valoareAdaugata)
        {
            this.valoareSold += valoareAdaugata;
            this.valoareSold *= (1 + rataDobanda); 
            Console.WriteLine("Tranzactie efectuata cu succes.");
        }
    }
}
