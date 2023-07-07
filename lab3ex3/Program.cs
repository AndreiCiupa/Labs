/* Lab 3 - Ex 3
 Scrieti o functie care va determina daca un numar este sau nu patrat perfect.
Apelati-o si afisati-i rezultatul.
*/

Console.Write("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());

if (!EstePatratPerfect(numar))
{
    Console.WriteLine("Numarul nu este patrat perfect.");
}
else
{ Console.WriteLine("Numarul este patrat perfect."); }

static bool EstePatratPerfect(int x)
{
    bool estePatratPerfect = false;
    for (int d = 2; d * d<= x; d++)
    {       
        if(d == x/d)
        {
            estePatratPerfect = true;
        }
    }
    return estePatratPerfect;
}
