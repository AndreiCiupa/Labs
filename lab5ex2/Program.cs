/* Lab 5 Ex 2
 * 
 Scrieti un program care sa verifice daca un sir de caractere citit de la
tastatura este sau nu palindrom.
*/

Console.Write("Enter string: ");
string str = Console.ReadLine();

if (IsPalindrome(str))
{
    Console.WriteLine("String is a palindrome.");
}
else
{
    Console.WriteLine("String is NOT a palindrome.");
}

static bool IsPalindrome(string s)
{
    bool isPalindrome = false;
    int j = s.Length - 1;
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] == s[j])
        {
            isPalindrome = true;
        }
        else 
        { 
            isPalindrome = false; 
            break; 
        }
        --j;
    }
    return isPalindrome;
}