// Ex 5
/*
 Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
• Exemplu: citim ,9,0 Afisam : 0 9
*/

Console.Write("Introduceti prima valoare: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Introduceti a doua valoare: ");
int y = int.Parse(Console.ReadLine());

if (x == y)
    Console.WriteLine("Introduceti doua valori distincte.");
else if (x < y) Console.WriteLine(x + " " + y);
else Console.WriteLine(y + " " + x);
