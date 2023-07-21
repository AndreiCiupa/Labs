/* Lab 5 Ex 1
 * 
 Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
siruri de caractere fiind citite de la tastatura
*/

Console.Write("Enter string: ");
string str = Console.ReadLine();

Console.Write("Enter substring: ");
string subStr = Console.ReadLine();

if (str.Contains(subStr))
{
    Console.WriteLine($"Substring starts from index {str.IndexOf(subStr)} of the string.");
}
else
{
    Console.WriteLine("String does not contain substring.");
}