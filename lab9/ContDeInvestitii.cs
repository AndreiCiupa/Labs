using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ContDeInvestitii : ContDeEconomii
    {
        private int termenDeExtragere;

        public ContDeInvestitii(string nume, int valoareSold, int rataDobanda, int termenDeExtragere) : base(nume, valoareSold, rataDobanda)
        {
            base.tipContBancar = TipContBancar.ContDeInvestitii;
            this.termenDeExtragere = termenDeExtragere;
            if (termenDeExtragere > 31)
            {
                this.termenDeExtragere = 31;
            }
            else if (termenDeExtragere < 1)
            {
                this.termenDeExtragere = 1;
            }
        }

        public override string GetDescription()
        {
            return this.nume + ", " + this.tipContBancar + ", " + this.valoareSold + ", " + this.rataDobanda + ", " + this.termenDeExtragere + ", " + this.id;
        }

        public override void ExtragereBani(int valoareExtrasa)
        { 
            if (this.termenDeExtragere > DateTime.Now.Day || valoareExtrasa > this.valoareSold)
            {
                Console.WriteLine("Tranzactie nereusita.");
            }
            else
            {
                this.valoareSold -= valoareExtrasa;
                Console.WriteLine("Tranzactie efectuata cu succes.");
            }
        }
    }
}
