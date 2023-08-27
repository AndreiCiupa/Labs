using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
