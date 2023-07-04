// Ex 4
/*
  Scrieti un program care va determina daca un numar este sau nu
palindrom.
*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());
int aux = n;

int mirror = 0;
while (n >= 1)
{
    mirror = mirror * 10 + (n % 10);
    n = (n - (n % 10)) / 10;
}

n = aux;

if(n < 0)
    Console.WriteLine("Numarul NU este un palindrom.");
else
{
    if (n == mirror)
        Console.WriteLine("Numarul este un palindrom.");
    else Console.WriteLine("Numarul NU este un palindrom.");
}