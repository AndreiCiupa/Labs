/* Lab 4 Supliment 2
  Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
cazurilor sa se afiseze numarul.
*/

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[] intNumere = new int[n];

for(int i = n-1; i>=0; i--)
{
    intNumere[i] = i+1;
}

//Afisare inainte
for (int i = 0; i < n; i++)
{
    Console.Write(intNumere[i] + " ");
}

Console.WriteLine("\n");

string[] stringNumere = Array.ConvertAll(intNumere, x => x.ToString());


for(int i = 0; i < n; i++)
{
    if (intNumere[i] % 3 == 0 && intNumere[i] % 5 != 0)
    {
        stringNumere[i] = "Fizz";
    }

    if (intNumere[i] % 3 != 0 && intNumere[i] % 5 == 0)
    {
        stringNumere[i] = "Buzz";
    }

    if (intNumere[i] % 3 == 0 && intNumere[i] % 5 == 0)
    {
        stringNumere[i] = "FizzBuzz";
    }
}

//Afisare dupa
for(int i = 0; i < n; i++)
{
    Console.Write(stringNumere[i] + " ");
}
Console.WriteLine();