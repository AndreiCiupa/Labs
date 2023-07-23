/* Lab 5 Ex 7
 * 
 Scrieti un program care va citi doua siruri de caractere de la tastatura si va
verifica daca cele doua siruri de caractere sunt anagrame.
*/

Console.Write("Enter the first string: ");
string str1 = Console.ReadLine();

Console.Write("Enter the second string: ");
string str2 = Console.ReadLine();

if (IsAnagram(str1, str2)) { Console.WriteLine("They are anagrams."); }
else { Console.WriteLine("They are not anagrams."); }

static string GetStringNoWhitespace(string str)
{
    for(int i = 0; i < str.Length; i++)
    {
        if (/*str[i] == ' ' */char.IsWhiteSpace(str[i]))
        {
            str = str.Remove(i, 1); // remove from the i-nth (i-nth included!), but just one
        }
    }

    return str;
}

static string GetSortedString(string str)
{
    char[] convertedString = str.ToCharArray();
    Array.Sort(convertedString);
    string sortedString = new string(convertedString);
    return sortedString;
}

static bool IsAnagram(string str1, string str2)
{
    str1 = GetStringNoWhitespace(str1);
    str1 = str1.ToLower();

    str2 = GetStringNoWhitespace(str2);
    str2 = str2.ToLower();

    int length1 = str1.Count();
    int length2 = str2.Count();

    if (length1 != length2) { return false; }

    str1 = GetSortedString(str1);
    str2 = GetSortedString(str2);

    for (int i = 0; i < length1; i++)
    {
        if (str1[i] != str2[i])
        {
            return false;
        }
    }

    return true;
}