/* Lab3 - Ex 1
 * Scrieti o functie care va calcula suma cifrelor unui numar.
*/

Console.Write("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());

int sumaCifrelor = SumaCifrelor(numar);

Console.WriteLine("Suma cifrelor numarului introdus este: " + sumaCifrelor);

static int SumaCifrelor(int x)
{
    int suma = 0;
    while (x > 0)
    {
        suma += x%10; // suma = suma + x%10;
        x /= 10; // x = x / 10;
    }
    return suma;
}