using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Count >= Capacity)
            {
                return "No seats in the classroom";
            }
            else
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student current = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (current == null)
            {
                return "Student not found";
            }
            else
            {
                students.Remove(current);
                return $"Dismissed student {firstName} {lastName}";
            }
        }

        public string GetSubjectInfo(string subject)
        {          
            int enrolled = students.Where(x => x.Subject == subject).Count();
            
            if (enrolled == 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine($"Subject: {subject}");
                result.AppendLine("Students:");
                foreach (Student stu in students)
                {
                    if (stu.Subject == subject)
                    {
                        result.AppendLine($"{stu.FirstName} {stu.LastName}");
                    }
                }

                return result.ToString().Trim();
            }            
        }

        public int GetStudentsCount()
            => Count;

        public Student GetStudent(string firstName, string lastName)
        {
            Student current = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return current;
        }
    }
}
