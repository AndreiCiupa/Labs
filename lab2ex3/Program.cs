// Ex 3
/*
  Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatura
*/
Console.Write("Introduceti numarul de elemente ale sirului: ");
int n = int.Parse(Console.ReadLine());

int[] m = new int[n];

int count = 0;
int mediaAritmetica = 0;

Console.Write("Introduceti elementele sirului: ");
for (int i = 0; i < n; i++)
{
    m[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (m[i] % 2 == 0)
    {
        mediaAritmetica += m[i];
        count++;
    }
}

Console.WriteLine("S = " + mediaAritmetica);
Console.WriteLine("count = " + count);

mediaAritmetica /= count;

Console.WriteLine("Media aritmetica = " + mediaAritmetica);