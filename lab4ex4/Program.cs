/* Lab 4 Ex 4
 Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
intregi.
*/

Console.Write("Lungimea vectorului: ");
int lungimeVector = int.Parse(Console.ReadLine());

int[] vector = new int[lungimeVector];

Console.WriteLine("Elementele vectorului: ");
for (int i = 0; i < lungimeVector; i++)
{
    vector[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

AfisareVectorRecursiv(vector, lungimeVector - 1);

static void AfisareVectorRecursiv(int[] v, int i)
{
    if (i != -1)
    {
        AfisareVectorRecursiv(v, i-1);
        Console.WriteLine(v[i]);
    }
}