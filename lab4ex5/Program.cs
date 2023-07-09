/* Lab 4 Ex 5
  Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
apelati-o si afisati-i rezultatul.
*/

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumaN(n));

static int SumaN(int n)
{
    if (n != 0)
    return n + SumaN(n-1); 
    else return n;
}