// Ex 1
/*
 Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.
*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());

int sumaCifre = 0;

while (n != 0)
{
    sumaCifre += (n % 10);
    n /= 10;
}

Console.WriteLine("Suma cifrelor este: "+sumaCifre);