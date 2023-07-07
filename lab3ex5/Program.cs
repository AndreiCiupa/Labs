/* Lab 3 Ex 5
 * Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi, aceasta s-a apucat să
prepare clătite. Arpsod mănâncă toate clătitele începând de la a N-a clătită preparată, până
la a M-a clătită preparată (inclusiv N și M). Pentru că el vrea să mănânce clătite cu diferite
umpluturi și-a făcut următoarea regulă:

 Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
 Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
 Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
 Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”

• Cerința
 Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
numărul de clătite din fiecare tip. A

• Indicii
1. iteratorul unui for nu incepe neaparat de la 1 ☺
2. folositi functii: extrageti operatiile matematice complicate asupra intregilor in functii. Veti
simplifica astfel partea de logica.
*/

Console.Write("Introduceti n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Introduceti m: ");
int m = int.Parse(Console.ReadLine());

int[] ordineClatite = new int[m];

for (int i = 0; i < m; i++)
{
    ordineClatite[i] = i + 1;
}

Console.WriteLine("Arpsod a mancat " + ClatiteCuCiocolata(n, ordineClatite) + " clatite cu ciocolata.");
Console.WriteLine("Arpsod a mancat " + ClatiteCuGem(n, ordineClatite) + " clatite cu gem.");
Console.WriteLine("Arpsod a mancat " + ClatiteCuInghetata(n, ordineClatite) + " clatite cu inghetata.");
Console.WriteLine("Arpsod a mancat " + ClatiteCuZahar(n, ordineClatite) + " clatite cu zahar.");
Console.WriteLine("Arpsod a mancat " + ClatiteSimple(n, ordineClatite) + " clatite simple.");

Console.WriteLine();

int totalClatiteMancate = m - n + 1;

Console.WriteLine("Arpsod a mancat " + totalClatiteMancate + " clatite.");

//FUNCTII

// Functie verifica primalitate (clatite cioco)
static bool EstePrim(int x)
{
    if (x == 0 || x == 1)
    { return false; }
    else
    {
        for (int d = 2; d * d <= x; d++)
        {
            if (x % d == 0)
                return false;
        }
        return true;
    }

}

// Functie verifica patrat perfect (clatite cu gem pt 1)
static bool EstePatratPerfect(int x)
{
    bool estePatratPerfect = false;
    for (int d = 2; d * d <= x; d++)
    {
        if (d == x / d)
        {
            estePatratPerfect = true;
        }
    }
    return estePatratPerfect;
}

// Functie verifica cub perfect (clatite cu gem pt 2)
static bool EsteCubPerfect(int x)
{
    bool esteCubPerfect = false;
    for (int d = 2; d * d * d <= x; d++)
    {
        if (x == d * d * d)
        {
            esteCubPerfect = true;
        }
    }
    return esteCubPerfect;
}

// Functie suma divizori (clatite cu inghetata)
static int SumaDivizori(int x)
{
    int suma = 1;
    for(int d = 2; d * d <= x; d++)
    {
        if(x%d == 0)
        {
            suma += d; 
        }
    }
    return suma;
}

// 1 Contorizeaza nrele prime (clatitele cu cioco) 
static int ClatiteCuCiocolata(int x, int[] v)
{
    int numarClatiteCiocolata = 0;
    for (int i = x - 1; i < v.Length; i++)
    {
        if (EstePrim(v[i]))
        {
            numarClatiteCiocolata++;
        }
    }
    return numarClatiteCiocolata;
}

// 2 Contorizeaza nrele care sunt patrate perfecte si cuburi perfecte (clatitele cu gem) 
static int ClatiteCuGem(int x, int[] v)
{
    int numarClatiteGem = 0;
    for (int i = x - 1; i < v.Length; i++)
    {
        if (EstePatratPerfect(v[i]) || EsteCubPerfect(v[i]))
        {
            numarClatiteGem++;
        }
    }
    return numarClatiteGem;
}

// 3 Contorizeaza nrele care sunt egale cu suma divizorilor sai (clatitele cu inghetata) 
static int ClatiteCuInghetata(int x, int[] v)
{
    int numarClatiteInghetata = 0;
    for (int i = x - 1; i < v.Length; i++)
    {
        if (v[i] == SumaDivizori(v[i]))
        {
            numarClatiteInghetata++;
        }
    }
    return numarClatiteInghetata;
}

// 4 Contorizeaza nrele care nu indeplinesc conditiile de mai sus dar sunt pare (clatitele cu zahar) 
static int ClatiteCuZahar(int x, int[] v)
{
    int numarClatiteZahar = 0;
    for (int i = x - 1; i < v.Length; i++)
    {
        if (!EstePrim(v[i]) && !EstePatratPerfect(v[i]) && !EsteCubPerfect(v[i]) && v[i] != SumaDivizori(v[i]) && v[i]%2 ==0)
        {
            numarClatiteZahar++;
        }
    }
    return numarClatiteZahar;
}

// 5 Contorizeaza nrele care nu indeplinesc conditiile de mai sus dar sunt impare (clatitele simple) 
static int ClatiteSimple(int x, int[] v)
{
    int numarClatiteSimple = 0;
    for (int i = x - 1; i < v.Length; i++)
    {
        if (!EstePrim(v[i]) && !EstePatratPerfect(v[i]) && !EsteCubPerfect(v[i]) && v[i] != SumaDivizori(v[i]) && v[i] % 2 != 0)
        {
            numarClatiteSimple++;
        }
    }
    return numarClatiteSimple;
}
