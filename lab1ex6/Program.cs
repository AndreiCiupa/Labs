// Ex 6
/*
  Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3,9,0 Afisam : 9 3 0
*/

Console.Write("Introduceti prima valoare: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Introduceti a doua valoare: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Introduceti a treia valoare: ");
int z = int.Parse(Console.ReadLine());

if (z > y) // else y < z
{
    if (z > x) // else x > z
    {
        if (y > x)
        {
            Console.WriteLine(z + " " + y + " " + x);
        }
        else Console.WriteLine(z + " " + x + " " + y);
    }
    else
    {
        if (x > y)
        {
            Console.WriteLine(x + " " + z + " " + y);
        }
        else
        {
            Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
else
{
    if (y > x)
    {
        if (x > z)
        {
            Console.WriteLine(y + " " + x + " " + z);
        }
        else
        {
            Console.WriteLine(y + " " + z + " " + y);
        }
    }
}