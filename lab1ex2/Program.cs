//Ex2
/*
 Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura
*/

Console.Write("Introduceti primul numar: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Introduceti al 2-lea numar: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Introduceti al 3-lea numar: ");
int z = int.Parse(Console.ReadLine());

int medieAritmetica = (x + y + z) / 3;
Console.WriteLine("Media aritmetica a celor trei numere este: " + medieAritmetica);

