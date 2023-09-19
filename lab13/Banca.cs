using lab13.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal sealed class Banca
    {
        public IDictionary<Guid, ContBancar> conturiCurente = new Dictionary<Guid, ContBancar>();
        public IDictionary<Guid, Card> caruriEmise = new Dictionary<Guid, Card>();
        private IDictionary<Guid, Guid> carduriSiConturi = new Dictionary<Guid, Guid>();
        private static int conexiuniActive = 0;

        private Banca() { }
        private static Banca bancaUnica;
        public static Banca GetBanca()
        {
            if (bancaUnica == null)
            {
                bancaUnica = new Banca();
            }
            return bancaUnica;
        }

        public Guid CreeazaCont()
        {
            ContBancar contNou = new ContBancar();

            contNou.idCont = Guid.NewGuid();

            conturiCurente.Add(contNou.idCont, contNou);

            //Console.WriteLine("Contul cu urmatorul id a fost creeat: ");

            return contNou.idCont;
        }

        public void EmiteCard(Guid idCont)
        {
            int i = 0;
            ContBancar cont = conturiCurente[idCont];

            foreach (KeyValuePair<Guid, Guid> kvp in carduriSiConturi)
            {
                if(kvp.Value == idCont)
                {
                    i++;
                }
            }

            if (!conturiCurente.ContainsKey(idCont))
            {
                throw new ContInexistentException("Cont invalid.");
            }
            if (cont.carduriEmise ==  2)
            {
                throw new NumarCarduriAtinsException("Numarul de carduri permis a fost atins.");
            }
            else
            {
                Card cardNou = new Card();

                cardNou.idCard = Guid.NewGuid();

                carduriSiConturi.Add(cardNou.idCard, idCont);
                caruriEmise.Add(cardNou.idCard, cardNou);
                
                Console.WriteLine("Card emis cu succes.");

                cont.carduriEmise++;
            }
        }

        public void Plateste(int suma, Guid idCard)
        {
            bool contIdentificat = false;
            Guid idContIdentificat = Guid.Empty;
            ContBancar contGasit = new ContBancar(); 

            foreach (KeyValuePair<Guid, Guid> kvp in carduriSiConturi)
            {
                if (kvp.Key == idCard)
                {
                    Console.WriteLine("Cont {0} identificat.", kvp.Key);
                    contIdentificat = true;
                    idContIdentificat = kvp.Value;
                }
            }

            foreach (KeyValuePair<Guid, ContBancar> kvp in conturiCurente)
            {
                if (kvp.Key == idContIdentificat)
                {
                    contGasit = kvp.Value;
                }
            }

            if (!carduriSiConturi.ContainsKey(idCard))
            {
                throw new CardInvalidException("Card invalid.");
            }
            else if(!contIdentificat)
            {
                throw new ContInexistentException("Cont invalid.");
            }
            else
            {
                contGasit.ExtrageNumerar(suma);
            }
        }

        public void Connect()
        {
            if(conexiuniActive == 3)
            {
                throw new NrConexiuniMAxAtinsException("Numarul maxim de conexiuni active a fost atins.");
            }
            else
            {
                conexiuniActive += 1;
                Console.WriteLine("Connected.");
            }
        }

        public void Disconnect()
        {
            conexiuniActive -= 1;
            Console.WriteLine("Disconnected.");
        }
    
    }
}
