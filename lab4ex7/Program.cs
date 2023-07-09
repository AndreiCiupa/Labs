/* Lab 4 Ex 7
  Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
afisa urmatoarea piramida a numerelor:

1
2 2
3 3 3
4 4 4 4
…
n n n ….. n

*/

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Piramida(n, n);

static void AfisareLinie(int n, int valoare)
{
    if (n == 0)
        return;
    Console.Write(valoare + " ");
    AfisareLinie(n - 1, valoare);
} 

static void Piramida(int n, int numar)
{
    if (n == 0) return;
    AfisareLinie(numar - n + 1, numar - n + 1);
    Console.WriteLine();
    Piramida(n-1, numar);
}