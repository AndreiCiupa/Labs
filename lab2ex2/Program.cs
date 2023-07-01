// Ex 2
/*
  Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.
*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());

int x = n;
int factorial = n;

if (n == 0)
    Console.WriteLine(1);
else while (n != 1)
    {
        factorial = factorial * (n - 1);
        n = n - 1;
    }
Console.WriteLine(x+"! = "+factorial);