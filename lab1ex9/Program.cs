// Ex 9
/*
 Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar
intreg va verifica urmatoarele
“unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz 
*/

Console.Write("Introduceti un numar: ");
int n = int.Parse(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine("unu");
        break;
    case 2:
        Console.WriteLine("doi");
        break;
    case 3:
        Console.WriteLine("trei");
        break;
    case 5:
        Console.WriteLine("cinci");
        break;
    case 8:
        Console.WriteLine("opt");
        break;
    default:
        Console.WriteLine("neidentificat");
        break;
}