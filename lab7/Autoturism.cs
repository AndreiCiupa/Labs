using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    /// <summary>
    /// 
    /// </summary>
    class Autoturism
    {
        private string marca;
        private string model;
        private int anFabricatie;
        private Motor motor;
        private int numarUsi;

        private static int nrInstanteCreate;
        private static Autoturism autoturismMax = new Autoturism();

        private Autoturism() { }

        public Autoturism(string marca, string model, int anFabricatie, Motor motor, int numarUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;
            this.numarUsi = numarUsi;

            Autoturism.nrInstanteCreate++;

            //if(autoturismMax == null)
            if(autoturismMax.marca == null && autoturismMax.model == null && autoturismMax.anFabricatie == 0 && autoturismMax.motor == null && autoturismMax.numarUsi == 0)
            {
                autoturismMax.marca = marca;
                autoturismMax.model = model;
                autoturismMax.anFabricatie = anFabricatie;
                autoturismMax.motor = motor;
                autoturismMax.numarUsi = numarUsi;
            }
            else if(autoturismMax.motor.GetPutere() < this.motor.GetPutere())
            {
                autoturismMax.marca = this.marca;
                autoturismMax.model = this.model;
                autoturismMax.anFabricatie = this.anFabricatie;
                autoturismMax.motor = this.motor;
                autoturismMax.numarUsi = this.numarUsi;
            }
        }

        public string GetDescription()
        {
            return this.marca + ", " + this.model + ", " + this.anFabricatie + ", " + this.motor.GetCapacitateCilindrica() + ", " + this.motor.GetCombustibil() + ", " + this.motor.GetPutere() + ", " + this.numarUsi;
        }

        public void PornesteMasina()
        {
            //Usa[] vectorUsi = new Usa[this.numarUsi];

            Console.WriteLine("masina porneste");
            this.motor.PornireMotor();
            //for (int i = 0; i < vectorUsi.Length; i++) { vectorUsi[i].Inchide(); }
            Usa usa = new Usa();
            usa.Inchide();
        }

        public void OpresteMasina()
        {
            //Usa[] vectorUsi = new Usa[this.numarUsi];

            Console.WriteLine("masina opreste");
            this.motor.OprireMotor();
            //for (int i = 0; i < vectorUsi.Length; i++) { vectorUsi[i].Deschide(); }
            Usa usa = new Usa();
            usa.Deschide();
        }

        public static int GetNrAutoturismeCreate()
        {
            return nrInstanteCreate;
        }

        public static Autoturism GetAutoturismPutereMaxima()
        {
            return autoturismMax;
        }      
    }
}
