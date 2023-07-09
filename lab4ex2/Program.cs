/* Lab 4 - Ex 2
 Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.

 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
rezultatul.

 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
rezultatul.
*/

// Se introduc de la tastatura dimensiunile
using System.Globalization;

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());

Console.Write("k = ");
int k = int.Parse(Console.ReadLine());

// Se declara matricea avand cele trei dimensiuni
int[,,] matrice = new int[n, m, k];

// Se introduc de la tastatura elemnetele matricei
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int l = 0; l < k; l++)
        {
            Console.Write("matrice [{0}, {1}, {2}] = ", i, j, l);
            matrice[i,j,l] = int.Parse(Console.ReadLine());
        }       
    }
}

// Se afiseaza matricea cu toate elementele sale
AfisareMatrice(matrice, n, m, k);

// Se afiseaza suma elementelor matricei
Console.WriteLine("Suma tutror elementelor din matrice este: " + SumaElementeMatrice(matrice, n, m, k));

// Se afiseaza elementul cu valoarea maxima a matricei
Console.WriteLine("Elementul cu valoarea maxima din matrice este: " + MaximMatrice(matrice, n, m, k));

static void AfisareMatrice(int[,,] matrice, int n, int m, int k)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{ ");
            for (int l = 0; l < k; l++)
            {
                Console.Write(matrice[i, j, l] + " ");
            }
            Console.WriteLine("}");
        }
        Console.WriteLine();
    }
}

static int SumaElementeMatrice(int[,,] matrice, int n, int m, int k)
{
    int sumaElementeMatrice = 0;

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            for(int l  = 0; l < k; l++)
            {
                sumaElementeMatrice += matrice[i,j,l];
            }
        }
    }

    return sumaElementeMatrice;
}

static int MaximMatrice(int[,,] matrice, int n, int m, int k)
{
    int maxim = matrice[0, 0, 0];
    
    for(int i = 0; i < n; i++)
    {
        if (i != 0)
        {
            if (matrice[i, 0, 0] > matrice[i - 1, 0, 0])
            {
                maxim = matrice[i, 0, 0];
            }
        }
        for( int j = 0; j < m; j++)
        {
            if (j != 0)
            {
                if (matrice[i, j, 0] > matrice[i, j-1, 0])
                {
                    maxim = matrice[i, j, 0];
                }
            }
            for (int l = 0; l < k; l++)
            {
                if (matrice[i,j,l] > maxim)
                    maxim = matrice[i, j, l];
            }
        }
    }
    
    return maxim;
}
