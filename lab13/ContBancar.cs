using lab13.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class ContBancar
    {
        public Guid idCont { get; set; }
        private int soldCurent { get; set; }
        public  int carduriEmise = 0;

        //List<Guid> carduriCont;

        public ContBancar()
        {
            //carduriCont = new List<Guid>(2);
        }

        public void DepuneNumerar(int sumaDeAdaugat)
        {
            soldCurent += sumaDeAdaugat;
        }

        public void ExtrageNumerar(int sumaDeExtras) 
        {
            if (soldCurent < sumaDeExtras)
            {
                throw new SoldInsuficientException("Sold insuficient. Tranzactie esuata.");
            }
            else
            {
                soldCurent -= sumaDeExtras;
            }
        }
    }
}
