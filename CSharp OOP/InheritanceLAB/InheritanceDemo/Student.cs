using System;
namespace InheritanceDemo
{
    public class Student : Person
    {
        public Student()
        {
            Console.WriteLine("In the empty student constuctor");
        }
        public Student(string school)
        {
            School = school;
            Console.WriteLine("In the student constuctor");
        }

        public string School { get; set; }

        public double Grade { get; set; }
    }
}
