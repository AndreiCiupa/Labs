/* Lab 5 Ex 7
 * 
 Scrieti un program care va citi doua siruri de caractere de la tastatura si va
verifica daca cele doua siruri de caractere sunt anagrame.
*/

Console.Write("Enter the first string: ");
string str1 = Console.ReadLine();

Console.Write("Enter the second string: ");
string str2 = Console.ReadLine();

if(IsAnagram(str1, str2)) { Console.WriteLine("They are anagrams."); }
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

static bool IsAnagram(string str1, string str2)
{
    bool isAnagram;

    str1 = GetStringNoWhitespace(str1);
    str1 = str1.ToLower();

    str2 = GetStringNoWhitespace(str2);
    str2 = str2.ToLower();

    if (str1.Length != str2.Length) { isAnagram = false; }
    else
    {
        for (int i = 0; i < str1.Length; i++)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i] == str2[j])
                {
                    str2 = str2.Substring(0, j) + str2.Substring(j + 1);
                    break;
                }
            }
            continue;
        }
        if (string.IsNullOrEmpty(str2)) { isAnagram = true; }
        else { isAnagram = false; }
    }

    return isAnagram;

    //int i = 0; 
    //for (int j = 0; j < str2.Length; j++)
    //{
    //    if (str1[i] == str2[j])
    //    {
    //        str2 = str2.Substring(0, j) + str2.Substring(j + 1);
    //        j++;
    //        str1 = str1.Substring(0, i) + str1.Substring(i + 1);
    //        i++;
    //    }
    //}
}