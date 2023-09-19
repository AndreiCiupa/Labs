using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal sealed class SistemGestiuneAngajati
    {
        private List<Angajat> angajati = new List<Angajat>();

        private SistemGestiuneAngajati() { }

        private static SistemGestiuneAngajati sistemGestiuneAngajati;

        public static SistemGestiuneAngajati GetSistemGA()
        {
            if (sistemGestiuneAngajati == null)
            {
                sistemGestiuneAngajati = new SistemGestiuneAngajati();
            }
            return sistemGestiuneAngajati;
        }

        public void AddEmployee(Angajat angajat) => angajati.Add(angajat);
        public void RemoveEmployee(Angajat angajat) => angajati.Remove(angajat);
        

        public void GetNoOfWellPayedEmployees(int number)
        {
            angajati.ForEach(angajat =>
            {
                if (angajat.salary <= number)
                {
                    return;
                }
                Console.WriteLine(angajat.ToString() + "\n");
            });

        }

        public void GetEmployeesByDepartment(Departamente departament)
        {
            angajati.ForEach(angajat =>
            {
                if (angajat.departament != departament)
                {
                    return;
                }
                Console.WriteLine(angajat.ToString() + "\n");
            });

        }

        public void GetMaxSalary()
        {
            double maxSalary = 0;
            angajati.ForEach(angajat =>
            {
                if (angajat.salary > maxSalary)
                {
                    maxSalary = angajat.salary;
                }
            });

            angajati.ForEach(angajat =>
            {
                if (angajat.salary == maxSalary)
                {
                    Console.WriteLine(angajat.ToString() + "\n");
                }
            });
        }

        public void GetMaxSalary(Departamente departament)
        {
            double maxSalary = 0;
            angajati.ForEach(angajat =>
            {
                if (angajat.departament == departament)
                {
                    if (angajat.salary > maxSalary)
                    {
                        maxSalary = angajat.salary;
                    } 
                }
            });

            angajati.ForEach(angajat =>
            {
                if (angajat.departament == departament)
                {
                    if (angajat.salary == maxSalary)
                    {
                        Console.WriteLine(angajat.ToString() + "\n");
                    } 
                }
            });
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            angajati.ForEach(angajat =>
            {
                totalCost += angajat.salary;
            });
            return totalCost;
        }
        public double GetCostForDepartment(Departamente departament)
        {
            double totalCost = 0;
            angajati.ForEach(angajat =>
            {
                if (angajat.departament == departament)
                {
                    totalCost += angajat.salary;
                }
            });
            return totalCost;
        }

        public void IncreaseSalary(Guid idAngajat, double procent)
        {
            Angajat angajat = angajati.Find(
            delegate(Angajat ang)
            {
                return ang.id == idAngajat;
            }
            );
            angajat.salary += (procent / 100) * angajat.salary;
        }

        public void IncreaseSalary(Departamente departament, double procent)
        {
            angajati.ForEach(angajat =>
            {
                if (angajat.departament == departament)
                {
                    angajat.salary += (procent / 100) * angajat.salary;
                }
            }); 
        }

        public void GetMaxSalary(List<Departamente> departamentList)
        {
            departamentList.ForEach(departament =>
            {
                GetMaxSalary(departament);
            });
        }

        public void IncreaseSalary(List<Departamente> departamentList, double procent)
        {
            departamentList.ForEach(departament =>
            {
                IncreaseSalary(departament, procent);
            });
        }

        //public void GetMaxSalaryByDepartment(List<Departamente> departamentList)
        //{
        //    departamentList.ForEach(departament =>
        //    {
        //        GetMaxSalary(departament);
        //    });
        //}
    }
}
