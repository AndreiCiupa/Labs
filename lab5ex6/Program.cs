/* Lab 5 Ex 6
 * 
 Screiti un program care va numara vocalele dintr-un sir de caractere citit de
la tastatura.
*/

Console.Write("Enter string: ");
string str = Console.ReadLine();

Console.WriteLine("Number of vowels in the string: " + GetNrVowels(str));

static int GetNrVowels(string s)
{
    int count = 0;
 
    s = s.ToLower();

    for(int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
        {
            count++;
        }
    }
    return count;
}