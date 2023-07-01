// Ex 8
/*
 Scrieti un program care interschimba valoarea a doua variabile intregi.
*/
Console.Write("Introduceti prima valoare: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Introduceti a doua valoare: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Inainte: ");
Console.WriteLine(a + " " + b);

int aux = a;
a = b;
b = aux;

Console.WriteLine("Dupa: ");
Console.WriteLine(a + " " + b);