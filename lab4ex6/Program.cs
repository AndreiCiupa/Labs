/* Lab 4 Ex 6
 Scrieti o functie recursiva care va calcula al n-lea element din sirul lui
Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul. 
*/

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Al " + n + "-lea numar Fibonacci: " + NthFibonacci(n));

static int NthFibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return NthFibonacci(n - 1) + NthFibonacci(n - 2);
    }
}