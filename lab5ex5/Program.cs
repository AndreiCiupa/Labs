/* Lab 5 Ex 5
 * 
 Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
Exemplu:
Input: Ana ARE mErE
Rezultat: Ana Are Mere
*/

Console.Write("Enter string: ");
string str = Console.ReadLine();

Console.WriteLine("The formatted string: " + GetFormatted(str));

//PASI
//toLower
//primul s[0] toUpper
//apoi parcurgere in care daca s[i] spatiu urmat index s[i+1] toUpper

static string GetFormatted(string str)
{
    str = str.ToLower();

    string subStr = str.Substring(1, str.Length - 1);

    str = char.ToUpper(str[0]) + subStr;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsWhiteSpace(str[i]))
        {
            string subStrStart = str.Substring(0, i+1);
            string subStrEnd = str.Substring(i + 2);
            str = subStrStart + char.ToUpper(str[i + 1]) + subStrEnd;
        }
    }
    return str;
}