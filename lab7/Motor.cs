using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Motor
    {
        private int capacitateCilindrica;
        private int putere;
        private string combustibil;

        public Motor(int capacitateCilindrica, int putere, string combustibil)
        {
            this.capacitateCilindrica = capacitateCilindrica;
            this.putere = putere;
            this.combustibil = combustibil;
        }   

        public int GetCapacitateCilindrica()
        {
            return capacitateCilindrica;
        }

        public int GetPutere()
        {
            return putere;
        }

        public string GetCombustibil()
        {
            return combustibil;
        }

        public void PornireMotor()
        {
            Console.WriteLine("brr");
        }
        public void OprireMotor()
        {
            Console.WriteLine("par poc pac");
        }
    }
}
