// LABORATOTR 18

/*
• Un autovehicul este caracterizat de urmatoarele proprietati
    • Id:int
    • Nume
    • Producator
    • Un numar variabil de chei (de la una la oricate)
    • O carte tehnica

• Cartea tehnica va avea urmatoarele:
    • Id:int
    • Capacitate cilindrica :int
    • An de fabricatie :int
    • Serie de sasiu: string

• Producatorul va avea
    • Id:int
    • Nume
    • Adresa:string

• O cheie va avea urmatoarele caracteristici
    • Id (int)
    • Cod de acces : Guid unic.
 */

/*
• Creeati modelul, Adaugati DB, populati DB

• Scrieti urmatoarele metode
    • Adaugare autovehicul
        • Implica adaugarea carei entitati?
    • Adaugare producator
    • Adaugare cheie unui autovehicul
    • Inlocuire carte tehnica
    • Stergere autovehicul
    • Stergere producator
    • Stergere cheie

• Determinati relatiile necesare

• Determinati delete propagation-ul necesar pentru fiecare
relatie in parte
 */

using lab18.Models;


Seed();


static void Seed()
{
    using var ctx = new ParcAutoDBContext();
    
    //Initializare
    var prd1 = new Producator
    {
        Nume = "Dacia",
        Adresa = "Havana"
    };
    var prd2 = new Producator
    {
        Nume = "Reanult",
        Adresa = "Florida"
    };

    var carteT1 = new CarteTehnica
    {
        CaapacitateCilindrica = 1000,
        AnFabricatie = 2000,
        SerieDeSasiu = "11111"
    };
    var carteT2 = new CarteTehnica
    {
        CaapacitateCilindrica = 1500,
        AnFabricatie = 2020,
        SerieDeSasiu = "22222"
    };

    var cheie1m1 = new Cheie();
    var cheie2m1 = new Cheie();
    var cheie1m2 = new Cheie();

    var autov1 = new Autovehicul
    {
        Nume = "Sandero",
        Producator = prd1,
        CarteTehnica = carteT1,
    };
    var autov2 = new Autovehicul
    {
        Nume = "whatever",
        Producator = prd2,
        CarteTehnica = carteT2,
    };

    //Populare liste
    autov1.Chei.Add(cheie1m1);
    autov1.Chei.Add(cheie2m1);

    autov2.Chei.Add(cheie1m2);

    prd1.Autovehicule.Add(autov1);
    prd2.Autovehicule.Add(autov2);

    //Adaugare in liste
    ctx.Autovehicule.Add(autov1);
    ctx.Autovehicule.Add(autov2);

    ctx.CartiTehnice.Add(carteT1);
    ctx.CartiTehnice.Add(carteT2);

    ctx.Chei.Add(cheie1m1);
    ctx.Chei.Add(cheie1m2);
    ctx.Chei.Add(cheie2m1);

    ctx.Producatori.Add(prd1);
    ctx.Producatori.Add(prd2);

    ctx.SaveChanges();
}