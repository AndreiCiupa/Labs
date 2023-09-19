// LABORATORUL 14

/*
 Scrieti un sistem de gestiune a angajatilor.

Angajatul va fi caracterizat de
• Nume
• Id :Guid
• Salary : double
• Department
• ToString – returneaza intr-o maniera prietenoasa toate informatiile despre angajat

Departamentele pot fi
• Development
• Testing
• HumanResources
• Maintenance
• Logistics

Sistemul de gestiune va fi unic la nivel de aplicatie si va fi modelat de o clasa care va avea urmatoarele :
• AddEmployee
o Adauga un angajat dat ca parametru

• RemoveEmployee
o Sterge un angajat in functie de ID-ul acestuia

• GetNoOfWellPayedEmployees
o Metoda va primi ca parametru o valoare numerica si va returna o lista cu toti angajatii
cu salariul mai mare decat valoarea numerica oferita ca parametru

• GetEmployeesByDepartment
o Va primi ca parametru un departament si va returna o lista cu toti angajatii din acel
departament

• GetMaxSalary
o O metoda fara parametri, care va returna angajatii cu cel mai mare salariu la nivel de
companie

• GetMaxSalary
o Metoda va primi ca parametru un departament si va returna angajatii cu cel mai mare
salariu din departamentul oferit ca parametru.

• GetTotalCost
o Metoda va returna o valoare numerica reprezentand suma tuturor salariilor din
companie

• GetCostForDepartment
o Metoda va returna o valoare numerica reprezentand suma tuturor salariilor din
departamentul oferit ca parametru

• IncreaseSalary
o Metoda va primi doi parametri, ID-ul angajatului si un procent si va mari salariul
angajatului cu procentul dat ca parametru

• IncreaseSalary
o Metoda va primi doi parametri, un departament si un procent si va mari salariile tuturor
angajatilor din acel departament cu procentul dat ca parametru

Instantiati clasele, adaugati angajati, accesati metodele, afisati rezultatele. Folositi expresii lambda,
functiile clasei List<T>: ForEach, FindAll, Count.

NU folositi instructiunea foreach

Suplimentar 2

Sistemul de gestiune va fi unic la nivel de aplicatie si modelat de o clasa care va avea urmatoarele :

• GetMaxSalary
o Metoda va primi ca parametru o lista de departamente si va returna angajatii cu cel mai
mare salariu din departamentele oferite ca parametru.

• IncreaseSalary
o Metoda va primi doi parametri, o lista de departamente si un procent si va mari salariile
tuturor angajatilor din departamentele specificate cu procentul dat ca parametru

• GetMaxSalaryByDepartment
o Metoda va primi ca parametru o lista de departamente si va returna pentru fiecare
departament, angajatii cu cel mai mare salariu.

!! Aruncati exceptiile necesare. !!

// EXCEPTION needed : cant add an already added
 */

using lab14;

SistemGestiuneAngajati sistem = SistemGestiuneAngajati.GetSistemGA();

//Logistics
Angajat angajat1 = new Angajat("Andreea", 3500, Departamente.Logistics);
sistem.AddEmployee(angajat1);

//Console.WriteLine(angajat1.ToString());

Angajat angajat2 = new Angajat("Andrei", 3800, Departamente.Logistics);
sistem.AddEmployee(angajat2);

//Testing

Angajat angajat3 = new Angajat("Paul", 4500, Departamente.Testing);
sistem.AddEmployee(angajat3);

Angajat angajat4 = new Angajat("Paula", 5000, Departamente.Testing);
sistem.AddEmployee(angajat4);

//Development

Angajat angajat5 = new Angajat("Mihai", 5500, Departamente.Development);
sistem.AddEmployee(angajat5);

Angajat angajat6 = new Angajat("Razvan", 6000, Departamente.Development);
sistem.AddEmployee(angajat6);

//Rezolvare:

//sistem.GetNoOfWellPayedEmployees(35000);

//sistem.GetEmployeesByDepartment(Departamente.Logistics);

//sistem.GetMaxSalary();

//sistem.GetMaxSalary(Departamente.Logistics);

//Console.WriteLine(sistem.GetTotalCost());
//Console.WriteLine(sistem.GetCostForDepartment(Departamente.Logistics));

//Console.WriteLine(angajat1.ToString());
//sistem.IncreaseSalary(angajat1.id, 15);
//Console.WriteLine(angajat1.ToString());

//sistem.IncreaseSalary(Departamente.Logistics, 20);
//Console.WriteLine(sistem.GetCostForDepartment(Departamente.Logistics));

List<Departamente> LTD = new List<Departamente>(3);
LTD.Add(Departamente.Logistics);
LTD.Add(Departamente.Testing);
LTD.Add(Departamente.Development);

sistem.GetMaxSalary(LTD);

Console.WriteLine(sistem.GetTotalCost());

sistem.IncreaseSalary(LTD, 30);
Console.WriteLine(sistem.GetTotalCost());

sistem.GetMaxSalary(LTD);