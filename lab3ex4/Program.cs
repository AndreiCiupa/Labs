/* Lab 3 - Ex 4
 * 
 Se citeste de la tastatura un vector continand n numere intregi, 
n fiind si el citit la randul sau citit de la tastatura.
 *
Scrieti functii care vor returna:
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
 *
Dificultate ridicata:
• Numerele prime din vector
 *
Apelati functiile si afisati-le rezultatele.
 *
*/

Console.Write("Introduceti lungimea verctorului: ");
int n = int.Parse(Console.ReadLine());

int[] v = new int[n];

Console.WriteLine("Introduceti elementele verctorului: ");
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

AfisareVector(v);
Console.WriteLine("Cel mai mare numar din vector este: "+ Maxim(v));
Console.WriteLine("Cel mai mic numar din vector este: " + Minim(v));
Console.Write("Numerele divizibile cu 3: ");
DivizibileCuTrei(v);
Console.Write("Numerele prime din vector: ");
Prime(v);


//Functie pentru afisarea vectorului
static void AfisareVector(int[] v)
{
    Console.Write("{ ");
    for (int i = 0;i < v.Length; i++)
    {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine("}");
}

//Functie pentru cautarea si returnarea valorii maxime
static int Maxim(int[] v)
{
    int max = v[0];

    for (int i = 0; i < v.Length; i++)
    {
        if (v[i] > max)
            max = v[i];
    }
    return max;
}

//Functie pentru cautarea si returnarea valorii minime
static int Minim(int[] v)
{
    int min = v[0];

    for (int i = 0; i < v.Length; i++)
    {
        if (v[i] < min)
            min = v[i];
    }
    return min;
}

//Functie pentru gasirea si afisarea numerelor divizibile cu 3
static void DivizibileCuTrei(int[] v)
{
    int contor = 0;
    for(int i = 0; i < v.Length; ++i)
    {
        if (v[i] % 3 == 0)
        {
            contor++;
        }
    }

    int[] divCuTrei = new int[contor];
    int j = 0;
    for (int i = 0; i < v.Length; ++i)
    {
        if (v[i] % 3 == 0)
        {
            divCuTrei[j]= v[i];
            j++;
        }
    }

    AfisareVector(divCuTrei);
}

// Functie verificare primalitate
static bool EstePrim(int x)
{
    if (x == 0 || x == 1)
    { return false; }
    else
    {
        for (int d = 2; d * d <= x; d++)
        {
            if (x % d == 0)
                return false;
        }
        return true;
    }

}

//Functie pentru gasirea + afisarea numerelor prime 
static void Prime(int[] v)
{
    int contor = 0;
    for (int i = 0; i < v.Length; ++i)
    {
        if (EstePrim(v[i]))
        {
            contor++;
        }
    }

    int[] prime = new int[contor];
    int j = 0;
    for (int i = 0; i < v.Length; ++i)
    {
        if (EstePrim(v[i]))
        {
            prime[j] = v[i];
            j++;
        }
    }

    AfisareVector(prime);
}