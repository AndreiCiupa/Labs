using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ContCurent : ContBancar 
    {
        public ContCurent(string nume, int valoareSold) : base(nume, valoareSold)
        {
            base.tipContBancar = TipContBancar.ContCurent;
        }

        public override string GetDescription()
        {
            return this.nume + ", " + this.tipContBancar + ", " + this.valoareSold + ", " + this.id;
        }

        public override void ExtragereBani(int valoareExtrasa)
        {
            if (valoareExtrasa > this.valoareSold)
            {
                if((valoareExtrasa - this.valoareSold) < 5000)
                {
                    this.valoareSold -= valoareExtrasa;
                    Console.WriteLine("Tranzactie efectuata cu succes.");
                }
                else
                {
                    Console.WriteLine("Tranzactie nereusita. Inafara limitei plafonului.");
                }
            }
            else
            {
                this.valoareSold -= valoareExtrasa;
                Console.WriteLine("Tranzactie efectuata cu succes.");
            }
        }
    }
}
