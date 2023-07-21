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

static bool IsAnagram(string str1, string str2)
{
    bool isAnagram = false;

    for(int i = 0; i < str1.Length; i++)
    {
        for (int j = 0; j < str2.Length; j++)
        {
            if (str1[i] == str2[j])
            {
                str2 = str2.Substring(0,j) + str2.Substring(j+1);
            }
        }
    }

    //Scapa de spatii !!!
    if(string.IsNullOrEmpty(str2)) { isAnagram = true; }
    else { isAnagram = false; }

    return isAnagram;
}