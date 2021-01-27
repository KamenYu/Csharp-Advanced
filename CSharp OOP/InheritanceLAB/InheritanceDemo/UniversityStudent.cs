using System;
namespace InheritanceDemo
{
    public class UniversityStudent : Student
    {
        public UniversityStudent() // empty ctor calls parent empty ctro
        {
            Console.WriteLine("In the empty uni student constructor");
        }

        public UniversityStudent(string school) : base (school)  // calling the base ctor
        { // ctor with parameters calls parent ctor with parameters
            School = school;
            Console.WriteLine("In the uni student constructor");
        }

        public string FacultyNumber { get; set; }
    }
          
}
