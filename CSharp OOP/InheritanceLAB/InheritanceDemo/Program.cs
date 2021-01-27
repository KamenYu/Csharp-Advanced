using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Age = 13;
            //Worker worker = new Worker();
            //worker.Name = "Diliboza";
            //FactoryWorker factoryWorker = new FactoryWorker();
            //factoryWorker.IsRisky = true;

            //Student student = new Student();
            //student.Age = 19;
            //student.Grade = 5.7;

            Student student2 = new Student("SoftUni");
            UniversityStudent universityStudent = new UniversityStudent();
            UniversityStudent universityStudent1 = new UniversityStudent("My Hero Academy");
            universityStudent1.FacultyNumber = "70066";



        }
    }
}
