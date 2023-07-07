/* Lab 3 - Ex 2
 * 
 Scrieti o functie care va determina daca un numar este sau nu numar prim.
Apelati-o si afisati-i rezultatul
*/

Console.Write("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());

bool estePrim = EstePrim(numar);

if (estePrim == true)
    Console.WriteLine("Numarul este Prim.");
else
    Console.WriteLine("Numarul nu este Prim.");

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