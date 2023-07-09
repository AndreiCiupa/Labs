/* Lab 4 Ex 3
 Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
rezultatul.
*/

// Se introduc de la tastatura dimensiunile
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());

// Se declara cele doua matrici avand cele 2 dimensiuni
int[,] matriceNM = new int[n, m];
int[,] matriceMN = new int[m, n];

// Se valorile si se afiseaza cele doua matrici
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write("A[{0},{1}] = ",i,j);
        matriceNM[i,j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("B[{0},{1}] = ", i, j);
        matriceMN[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

AfisareMatrice(matriceNM, n, m);

Console.WriteLine();

AfisareMatrice(matriceMN, m, n);

// Produsul lor

Console.WriteLine();
ProdusMatrice(matriceNM, matriceMN, n, m);

static void AfisareMatrice(int[,] matrice, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < m; j++)
        {
            Console.Write(matrice[i, j] + " ");
        }
        Console.WriteLine("}");
    }
}

static void ProdusMatrice(int[,] A, int[,] B, int n, int m)
{
    int dimensiuneProdus = n;

    int[,] produsAB= new int[dimensiuneProdus, dimensiuneProdus];

    for(int i = 0; i < dimensiuneProdus; i++)
    {
        for(int j = 0; j < dimensiuneProdus; j++)
        {
            produsAB[i, j] = 0;
            for(int k = 0; k < m; k++)
            {
                produsAB[i,j] += A[i, k] * B[k, j];
            }
        }
    }
    AfisareMatrice(produsAB, dimensiuneProdus, dimensiuneProdus);
}