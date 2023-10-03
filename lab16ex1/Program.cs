// LAB 16 - Ex 1
/*
• Un student este caracterizat de
    • Id (unic)
    • Nume
    • Prenume
    • Varsta
    • Specializare

• Specializarile vor fi
    • Informatica
    • Litere
    • Constructii

• Creeati modelul, adaugati EF 3.1,
    Adaugati DB

• Creeati in clasa “main” o functie
    “Seed” care va popula DB-ul

• Afisati toti studentii din DB in
    ordine alfabetica

• Afisati cel mai tanar student de
    la constructii cu varsta de peste
    20 de ani
*/

using lab16ex1;

//Seed();

ShowAllStudents();
Console.WriteLine();

ShowAllAlphbOrd();
Console.WriteLine();

YoungestStdConstr();
Console.WriteLine();

static void YoungestStdConstr()
{
    using var catalog = new StudentsDBContext();

    var ascByAgeConstructii = from s in catalog.Students
                              where s.Age > 20 && s.Major == MajorType.Constructii
                              orderby s.Age
                              select s;

    var firstFromAscByAgeConstr = ascByAgeConstructii.First();

    Console.WriteLine(firstFromAscByAgeConstr);
}
static void ShowAllAlphbOrd()
{
    using var catalog = new StudentsDBContext();

    var studentsAlphbOrd = from s in catalog.Students
                           select s;
    studentsAlphbOrd = studentsAlphbOrd.OrderBy(s => s.FirstName);
    studentsAlphbOrd = studentsAlphbOrd.OrderBy(s => s.LastName);

    foreach (var s in studentsAlphbOrd)
    {
        Console.WriteLine(s.ToString());
    }
}

static void ShowAllStudents()
{
    using var catalog = new StudentsDBContext();

    catalog.
        Students.
        ToList().
        ForEach(s => Console.WriteLine(s));
}

static void Seed()
{
    using var catalog = new StudentsDBContext();

    catalog.Students.Add(
        new Student 
        { 
            LastName = "Maior", 
            FirstName = "Luca", 
            Age = 17, 
            Major = MajorType.Informatica 
        }
        );

    catalog.Students.Add(
        new Student
        {
            LastName = "Albu",
            FirstName = "Sara",
            Age = 23,
            Major = MajorType.Constructii
        }
        );
    catalog.Students.Add(
        new Student
        {
            LastName = "Cuc",
            FirstName = "Adrian",
            Age = 30,
            Major = MajorType.Litere
        }
        );
    catalog.Students.Add(
        new Student
        {
            LastName = "Vasile",
            FirstName = "Andrei",
            Age = 24,
            Major = MajorType.Litere
        }
        );
    catalog.SaveChanges();
}