using lab13.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class POS
    {
        Banca banca = Banca.GetBanca();
        public void Plateste(int sumaDePlata, Card card)
        {
            card.IntroduCard();
            //• Se va asigura ca extragerea cardului a fost facuta si
            //in situatia in care plata a esuat
            try
            {
                Connect();
                card.GetCradData();
                banca.Plateste(sumaDePlata, card.idCard);
                banca.Disconnect();
            }
            finally 
            {
                card.ExtrageCard();
            }
        }

        private void Connect()
        {
            try
            {
                for(int i = 0; i < 2; i++)
                {
                    banca.Connect();
                }
            }
            catch(NrConexiuniMAxAtinsException)
            {
                throw new ConexiuneEsuataException("Conexiunea la banca nu s-a putut realiza.");
            }
//            • Va incerca de 2 ori conectarea la Banca.
//            • In cazul in care conectarea a esuat, va arunca o exceptie corespunzatoare
//          Metoda Connect va fi apelata dupa introducerea cardului.
//          Dupa efectuarea platii, Pos - ul se va deconecta de la banca.

        }
    }
}
