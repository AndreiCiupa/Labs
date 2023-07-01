// Ex 4
/*
  Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”
*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());

if (n == 0)
    Console.WriteLine(0);
else if (n > 0)
    Console.WriteLine("+");
else Console.WriteLine("-");
