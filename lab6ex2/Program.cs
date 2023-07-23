/* Lab 6 Ex 2
 * 
Ex 2
Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).

Autoturismul va avea:

 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.

Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.

Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
metodele “Tipareste”
*/

Autoturism masinaNoua = new Autoturism("Ford", "BH 12 ASA", 1753);
masinaNoua.Tiparire();

Autoturism masinaVeche = new Autoturism("Dacia", "BH 99 ZZY", 1397);
masinaVeche.Tiparire();

/// <summary>
/// Aceasta clasa modeleaza un autoturism
/// </summary>
class Autoturism
{
    private string marca;
    private string numarDeInmatriculare;
    private int capacitateCilindrica;
    /// <summary>
    /// Reprezinta un autoturism
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="numarDeInmatriculare"></param>
    /// <param name="capacitateCilindrica"></param>
    public Autoturism(string marca, string numarDeInmatriculare, int capacitateCilindrica)
    {
        this.marca = marca;
        this.numarDeInmatriculare = numarDeInmatriculare;
        this.capacitateCilindrica = capacitateCilindrica;
    }
    /// <summary>
    /// Afiseaza pe consola descrierea autoturismului
    /// </summary>
    public void Tiparire()
    {
        Console.WriteLine($"{this.marca}, {this.numarDeInmatriculare}, {this.capacitateCilindrica}");
    }
}