using lab10.Dispozitive;

namespace lab10
{
    class POS
    {
        public void PlataContactFull(int suma, Dispozitive.Dispozitiv dispozitiv)
        {
            if (dispozitiv is CardClasic)
            {
                (dispozitiv as CardClasic).IntroduCard();
                (dispozitiv as CardClasic).EfectueazaPlata(suma);
                (dispozitiv as CardClasic).ExtrageCard();
            }
            else if (dispozitiv is CardContactless)
            {
                (dispozitiv as CardContactless).IntroduCard();
                (dispozitiv as CardContactless).EfectueazaPlata(suma);
                (dispozitiv as CardContactless).ExtrageCard();
            }
        }

        public void PlataContactless(int suma, Dispozitive.Dispozitiv dispozitiv)
        {
            if (dispozitiv is Telefon)
            {
                (dispozitiv as Telefon).ApropieCard();
                (dispozitiv as Telefon).EfectueazaPlata(suma);
            }
            else if (dispozitiv is CardContactless)
            {
                (dispozitiv as CardContactless).ApropieCard();
                (dispozitiv as CardContactless).EfectueazaPlata(suma);
            }
        }
    }
}
