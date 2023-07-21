/* Lab 5 Ex 3
 * 
 Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
de caractere. Atat caracterul cautat cat si sirul de caracter vor fi citite de la
tastatura
*/
Console.Write("Enter string: ");
string str = Console.ReadLine();

Console.Write("Enter char: ");
char ch = (char)Console.Read();

Console.WriteLine($"The string contains the character {GetCountOf(str, ch)} times.");

static int GetCountOf(string s, char c)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c)
        {
            ++count;
        }
    }
    return count;
}

