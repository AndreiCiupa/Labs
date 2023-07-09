/* Lab 4 Supliment 1
 Se citesc doua numere de la tastatura. Scrieti un program care va calcula
cel mai mare divizor comun al numerelor
*/

int a = int.Parse(Console.ReadLine());

int b = int.Parse(Console.ReadLine());

int cmmdc = 1;

while(b != 0)
{
    var anteriorB = b;
    b = a % b;
    a = anteriorB;
}
Console.WriteLine("CMMDC = " +  a);