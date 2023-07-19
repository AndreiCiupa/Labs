/* Lab 4 - Ex 1
 Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
*/

Console.Write("Introduceti lungimea vectorului: ");
int n = int.Parse(Console.ReadLine());

int[] vector = new int[n];

Console.WriteLine("Introduceti elementele vectorului: ");
for (int i = 0; i < n; i++)
{
    vector[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Vectorul initial: ");
AfisareVector(vector);
InversareVector(vector);

Console.WriteLine("Vectorul inversat: ");
AfisareVector(vector);

static void AfisareVector(int[] v)
{
    Console.Write("{ ");
    for (int i = 0; i < v.Length; i++)
    {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine("}");
}

static void InversareVector(int[] v)
{
    // 2 4 1 15 3
    //
    int j = v.Length - 1;
    for(int i  = 0; i < v.Length/2; i++)
    {
        ///(v[j], v[i]) = (v[i], v[j]);
        int aux = v[i];
        v[i] = v[j];
        v[j]=aux;
        
        j--;
    }
}