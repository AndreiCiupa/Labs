/* Lab 5 Ex 4
 * 
 Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
de la tastatura, ignorand caseing-ul literelor.
Exemplu:
Input: Elena are mere
Output: e apare de 5 ori
*/

Console.Write("Enter string: ");
string str = Console.ReadLine();

Console.WriteLine(GetTheMostChar(str) + " apare de " + GetNumberOfChar(str,GetTheMostChar(str)) + " ori.");

static int GetNumberOfChar(string s, char c)
{
    int count = 0;

    s = s.ToLower();

    for (int i  = 0; i < s.Length; i++)
    {
        if (s[i] == c)
        {
            count++;
        }
    }

    return count;
}
static char GetTheMostChar(string s)
{
    char c = s[0];
    int count1 = 0;
    int count2 = 0;

    s = s.ToLower();

    for(int i  = 0; i < s.Length; i++)
    {
        count1 = count2;
        for(int j  = 0; j < s.Length; j++)
        {
            if (s[i] == s[j])
            {
                ++count2;
            }
        }
        if (count2 > count1)
        {
            c = s[i];
        }
    }

    return c;
}
