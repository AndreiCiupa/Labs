// LAB 16 - Ex 1
/*
• Un autovehicul este caracterizat de
    urmatoarele proprietati
        • Id:int
        • Nume
        • Serie de sasiu: string
        • An de fabricatie :int
        • Producator

• Producatorul va avea
        • Id:int
        • Nume
        • Adresa:string

• Creeati modelul, adaugati EF 3.1,
    Adaugati DB

• Creeati in clasa “main” o functie
    “Seed” care va popula DB-ul

• Afisati toate autovehiculele in ordine
    descrescatoare a anului de fabricatie

• Suplimentar
    • Afisati autovehiculele grupate in functie
      de numele producatorului sub forma

        “Autovehiculele producatorului Trabant”:
        Id, nume, serie, an de fabricatie
        . . .
        etc

 */

using lab16ex2.Models;
//Seed();
ShowByYearDesc();
Console.WriteLine();

GroupByProducator();
Console.WriteLine();

static void GroupByProducator()
{
    using var autovehicule = new VehiclesDBContext();

    var GroupByProducator = autovehicule.Autovehicule.GroupBy(v => v.Producator);

    foreach (var group in GroupByProducator)
    {
        Console.WriteLine($"Autovehiculele producatorului {group.Key}");
        foreach (var v in group)
        {
            Console.WriteLine(v);
        }
    }
}

static void ShowByYearDesc()
{
    using var autovehicule = new VehiclesDBContext();

    var vehiclesByYearDesc = from a in autovehicule.Autovehicule
                           orderby a.AnFabricatie descending
                           select a;

    foreach (var a in vehiclesByYearDesc)
    {
        Console.WriteLine(a);
    }
}

static void Seed()
{
    using var autovehicule = new VehiclesDBContext();
    
    var bmw = new Producator
    {
        Nume = "BMW",
        Adresa = "Clujului, 300A"
    };
    autovehicule.Producator.Add(bmw);
    
    var audi = new Producator
    {
        Nume = "Audi",
        Adresa = "Graurilor, 3"
    };
    autovehicule.Producator.Add(audi);
    
    autovehicule.Autovehicule.Add(
        new Autovehicul
        {
            Nume = "BMW seria 5",
            SerieDeSasiu = "1HGBH41JXMN109186",
            AnFabricatie = 2004,
            Producator = bmw
        }
        );

    autovehicule.Autovehicule.Add(
        new Autovehicul
        {
            Nume = "BMW i5",
            SerieDeSasiu = "WBAGG83461DN81194",
            AnFabricatie = 2005,
            Producator = bmw
        }
        );

    autovehicule.Autovehicule.Add(
        new Autovehicul
        {
            Nume = "Audi A5",
            SerieDeSasiu = "1XPVDP9X8CD176390",
            AnFabricatie = 2010,
            Producator = audi
        }
        );

    autovehicule.SaveChanges();
}