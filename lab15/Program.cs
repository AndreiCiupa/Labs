// LAB 15 - LINQ

//IMPORTANT
//• Folositi functiile LINQ studiate
//• Pentru exercitiul suplimentar, folositi google pentru a gasi
//documentatia functiei GroupBy

//• Un student este caracterizat de
//  • Id (unic)
//  • Nume
//  • Prenume
//  • Varsta
//  • Specializare

//• Specializarile vor fi
//  • Informatica
//  • Litere
//  • Constructii

//• Initializati si populati o lista de
//student si scrieti query-urile de
//mai jos
//  • Pentru a fi mai usoara corectarea,
//  va rog sa puneti in comment
//  cerinta inaintea fiecarui query

using lab15;

var students = new List<Student>()
    {
    new Student { LastName = "Maior", FirstName = "Luca", Age = 17, Major = MajorType.Informatica },
    new Student { LastName = "Albu", FirstName = "Sara", Age = 23, Major = MajorType.Informatica },
    new Student { LastName = "Vasile", FirstName = "Andrei", Age = 24, Major = MajorType.Litere },
    new Student { LastName = "Ciuciu", FirstName = "Alina", Age = 21, Major = MajorType.Litere },
    new Student { LastName = "Cuc", FirstName = "Adrian", Age = 30, Major = MajorType.Constructii },
    new Student { LastName = "Rat", FirstName = "Bogdan", Age = 21, Major = MajorType.Constructii },

    };

students.ForEach(student => Console.WriteLine(student.ToString()));
Console.WriteLine();

//1.Afisati cel mai in varsta student de la Informatica

var infoStudents = from s in students
                   where s.Major == MajorType.Informatica
                   select s;

var maxAgeInfo = infoStudents.Max(s => s.Age);

var olderStudentsInfo = from s in infoStudents
                        where s.Age == maxAgeInfo
                        select s;

foreach (var s in olderStudentsInfo)
{
    Console.WriteLine(s.ToString());
}
Console.WriteLine();

/*
2. Afisati cel mai tanar student
  • In mai multe moduri
*/

// MET 1 - asemanator cu ex 1, dar min si din total studenti

var minAge = students.Min(s => s.Age);

var youngerStudents = from s in students
                      where s.Age == minAge
                      select s;

foreach (var s in youngerStudents)
{
    Console.WriteLine(s.ToString());
}
Console.WriteLine();

// MET 2 - prin ordonare crescatoare dupa varsta si afisarea primului

var ascendingOrderByAge = from s in students
                          orderby s.Age
                          select s;

var youngerStudent = ascendingOrderByAge.First();

Console.WriteLine(youngerStudent.ToString());
Console.WriteLine();

//3. Afisati in ordine crescatoare a varstei toti,
//  studentii de la litere.

var studentsLitere = from s in students
                     where s.Major == MajorType.Litere
                     orderby s.Age
                     select s;

foreach(var s in studentsLitere)
{
    Console.WriteLine(s.ToString());
}
Console.WriteLine();

//4. Afisati primul student de la constructii cu
//  varsta de peste 20 de ani

var ascByAgeConstructii = from s in students
                          where s.Age > 20 && s.Major == MajorType.Constructii
                          orderby s.Age
                          select s;

var firstFromAscByAgeConstr = ascByAgeConstructii.First();

Console.WriteLine(firstFromAscByAgeConstr.ToString());
Console.WriteLine();

//5. Afisati studentii avand varsta egala cu
//  varsta medie a studentilor

var averageAge = Math.Round(students.Average(s => s.Age));

var avgAgeStudents = from s in students
                     where s.Age == averageAge
                     select s;

foreach (var s in avgAgeStudents)
{
    Console.WriteLine(s.ToString());
}
Console.WriteLine();

/*
6. Afisati, in ordinea descrescatoare a varstei,
  si in ordine alfabetica, dupa numele de
  familie si dupa numele mic, toti studentii
  cu varsta cuprinsa intre 18 si 35 de ani
*/

var orderByEx6 = from s in students
                 where s.Age > 18 && s.Age < 35
                 select s;

//orderByEx6 = orderByEx6.OrderBy(s => s.Age);
//orderByEx6 = orderByEx6.OrderBy(s => s.LastName);
//orderByEx6 = orderByEx6.OrderBy(s => s.FirstName);

orderByEx6 = orderByEx6.OrderBy(s => s.FirstName);
orderByEx6 = orderByEx6.OrderBy(s => s.LastName);
orderByEx6 = orderByEx6.OrderBy(s => s.Age);

foreach (var s in orderByEx6)
{
    Console.WriteLine(s.ToString());
}
Console.WriteLine();


//7. Afisati ultimul elev din lista folosind linq

var lastStudent = students.LastOrDefault();
Console.WriteLine(lastStudent.ToString());
Console.WriteLine();

/*
8. Afisati mesajul “Exista si minori” daca in lista
  creeata exista si persone cu varsta mai mica de
  18 ani. In caz contar afesati “Nu exista minori”
*/

if (students.Count(s => s.Age<18) == 0)
{
    Console.WriteLine("Nu exista minori.");
}
else
{
    Console.WriteLine("Exista si minori");
}
Console.WriteLine();

//Suplimentar
/*
9. Folosind GroupBy, afisati toti studentii grupati
    in functie de varsta sub forma urmatoare
    Studentii cu varsta de 20 de ani
    Student1.toString
    Student2.toString
    Student3.toString
    Studentii cu varsta de 25 de ani
    .
    .
    .
*/

var groupByAge = from s in students
                  group s by s.Age into newGroup
                  orderby newGroup.Key
                  select newGroup;

foreach (var group in groupByAge)
{
    Console.WriteLine($"Studentii cu varsta de {group.Key} de ani");
    foreach (var s in group)
    {
            Console.WriteLine(s.ToString());
    }
}
