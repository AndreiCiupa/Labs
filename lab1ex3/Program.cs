// Ex3
/*
 Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastatura
*/

Console.Write("Introduceti un numar intreg: ");
int n = int.Parse(Console.ReadLine());

int ultimaCifra = n % 10;
Console.WriteLine("Ultima cifra a numarului este:" + ultimaCifra);
