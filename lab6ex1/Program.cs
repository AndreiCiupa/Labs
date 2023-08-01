/* Lab 6 Ex 1
 * 
 Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.

Folositi o clasa care va modela un dulap.

 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.

Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul
*/

Console.Write("L = ");
int L = int.Parse(Console.ReadLine());

Console.Write("l = ");
int l = int.Parse(Console.ReadLine());

Console.Write("h = ");
int h = int.Parse(Console.ReadLine());

Dulap dulap = new Dulap(L, l, h);

Console.WriteLine("Volumul dulapului: " + dulap.GetVolume());

class Dulap
{
    private int lungime;
    private int latime;
    private int inaltime;
   
    public Dulap(int lungime, int latime, int inaltime)
    {
        this.lungime = lungime;
        this.latime = latime;
        this.inaltime = inaltime;
    }

    public int GetVolume()
    {
        int volum = this.lungime * this.latime * this.inaltime;
        return volum;
    }
}