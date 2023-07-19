/* Lab 3 - Ex 3
 Scrieti o functie care va determina daca un numar este sau nu patrat perfect.
Apelati-o si afisati-i rezultatul.
*/


Console.Write("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());

if (EstePatratPerfect(numar))
{ Console.WriteLine("Numarul este patrat perfect."); }
else
{
    Console.WriteLine("Numarul nu este patrat perfect.");
}

static bool EstePatratPerfect(int x)
{
    for (int d = 2; d <= Math.Sqrt(x); d++)
    {
        if (d * d == x)
        {
            return true;
        }
    }
    return false;
}