/* Lab 5 Ex Suplimentar
 * 
 Catalog

Scrieti un program care va citi de la tastatura un numar n de elevi.

Elevii vor avea nume, prenume precum si un numar de note m specific fiecarui
elev si citit si el de la tastatura.

Notele fiecarui elev vor fi la randul lor citite de la tastatura.

 Programul va afisa informatiile elevului cu media cea mai mare
nume, prenume ,medie generala

*/


Console.Write("Introduceti numarul de elevi: ");
int n = int.Parse(Console.ReadLine());

int m;

string[] numeElevi = new string[n];
string[] prenumeElevi = new string[n];
int[] numarNoteElevi = new int[n];
int[,] noteElevi = new int[n,n]; //NU E OK, numarul de note nu e egal cu nrul de elevi...... stuck


for (int i = 0; i < n; i++)
{
    Console.Write("Introduceti numele elevului: ");
    numeElevi[i] = Console.ReadLine();

    Console.Write("Introduceti prenumele elevului: ");
    prenumeElevi[i] = Console.ReadLine();

    Console.Write("Introduceti numarul de note al elevului: ");
    m = int.Parse(Console.ReadLine());

    numarNoteElevi[i] = m;

    for(int j = 0; j < m; j++)
    {
        Console.Write("Introduceti nota elevului: ");
        noteElevi[i,j] = int.Parse(Console.ReadLine());
    }
}


static int[] GetPerformances(int[] numarNoteElevi, int[,] noteElevi)
{
    int[] medii = new int[numarNoteElevi.Length];

    for( int i = 0;i < numarNoteElevi.Length; i++)
    {
        int medieNote = 0;
        for( int j = 0; j < numarNoteElevi.Length; j++)
        {
            medieNote += noteElevi[i,j];
        }
        medieNote /= numarNoteElevi[i];
        medii[i] = medieNote;
    }
    return medii;
}

static string GetBestStudent(string[] numeElevi, string[] prenumeElevi, int[] medii)
{
    string Student = "";

    for( int i = 0;i < medii.Length; i++)
    {
        if (medii[i] == medii.Max())
        {
            string medie = medii.Max().ToString();
            Student = numeElevi[i] + ' ' + prenumeElevi[i] + ' ' + medie;
        }
    }

    return Student;
}