// Ex 7
/*
  Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number
*/
Console.Write("Introduceti o valoare: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine("par");
else Console.WriteLine("impar");
