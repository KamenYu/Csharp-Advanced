using System;
using System.Collections.Generic;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            List<IEmployee> employees = new List<IEmployee>();
            List<string> documents = new List<string>() { "Doc1", "Appraisals", "MoneyScams" };
            employees.Add(new Manager("Mike", documents));
            employees.Add(new Employee("Rigdorajron"));
            employees.Add(new Employee("Emfilikinistibolmitoh"));
            employees.Add(new Employee("Gniorvelidana"));
            employees.Add(new Cleaner("Penka", 6));
            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
