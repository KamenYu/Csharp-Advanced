namespace BakeryOpenning
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository
            Bakery bakery = new Bakery("Barny", 4);
            //Initialize entity
            Employee employee = new Employee("Citiridis", 42, "Bosnja");
            Employee employee1 = new Employee("Nikolaus", 45, "Belarus");
            Employee employee2 = new Employee("Rose", 22, "USA");
            Employee employee3 = new Employee("Stephen", 12, "UAE");
            Employee employee4 = new Employee("Sonja", 4, "SAR");
            Employee employee5 = new Employee("Smith", 43, "Bulgaria");
            Console.WriteLine(bakery.Count);
            //Print Employee
            Console.WriteLine(employee); //Employee: Stephen, 40 (Bulgaria)

            //Add Employee
            bakery.Add(employee);
            bakery.Add(employee1);
            bakery.Add(employee2);
            bakery.Add(employee3);
            bakery.Add(employee4);
            bakery.Add(employee5);
            Console.WriteLine(bakery.Count);
            //Remove Employee
            Console.WriteLine(bakery.Remove("Employee name")); //false

            Employee secondEmployee = new Employee("Mark", 34, "UK");

            //Add Employee
            bakery.Add(secondEmployee);

            Employee oldestEmployee = bakery.GetOldestEmployee(); // Employee with name Stephen
            Employee employeeStephen = bakery.GetEmployee("Stephen"); // Employee with name Stephen
            Console.WriteLine(oldestEmployee); //Employee: Stephen, 40 (Bulgaria)
            Console.WriteLine(employeeStephen); //Employee: Stephen, 40 (Bulgaria)

            Console.WriteLine(bakery.Count); //2

            Console.WriteLine(bakery.Report());
            //Employees working at Bakery Barny:
            //Employee: Stephen, 40 (Bulgaria)
            //Employee: Mark, 34 (UK)
        }
    }
}
