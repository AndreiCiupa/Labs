/* Lab 3 - Ex 2
 * 
 Scrieti o functie care va determina daca un numar este sau nu numar prim.
Apelati-o si afisati-i rezultatul
*/

Console.Write("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());

if (EstePrim(numar))
    Console.WriteLine("Numarul este Prim.");
else
    Console.WriteLine("Numarul nu este Prim.");

static bool EstePrim(int x)
{
    if (x == 0 || x == 1)
    { return false; }
    else
    {
        for (int i = 2; i < x/2; i++)
        {
            if (x % i == 0)
                return false;
        }
        return true;
    }
}