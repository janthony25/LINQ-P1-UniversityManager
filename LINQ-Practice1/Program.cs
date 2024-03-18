using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
           
            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        List<University> universities = new List<University> ();
        List<Student> students = new List<Student> ();

        public UniversityManager()
        {
            universities = new List<University> ();
            students = new List<Student> ();

            universities.Add(new University { UniversityId = 1, UniversityName = "Yale" });
            universities.Add(new University { UniversityId = 2, UniversityName = "Beijing Tech" });

            students.Add(new Student { StudentId = 1, StudentName = "Carla", StudentGender = "Female", StudentAge = 17, UniversityId = 1 });
            students.Add(new Student { StudentId = 2, StudentName = "Toni", StudentGender = "male", StudentAge = 21, UniversityId = 1 });
            students.Add(new Student { StudentId = 3, StudentName = "Leyla", StudentGender = "Female", StudentAge = 19, UniversityId = 2 });
            students.Add(new Student { StudentId = 4, StudentName = "James", StudentGender = "trans-gender", StudentAge = 25, UniversityId = 2 });
            students.Add(new Student { StudentId = 5, StudentName = "Linda", StudentGender = "Female", StudentAge = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                            where student.StudentGender == "male"
                                            select student;

            Console.WriteLine("------------ Male Students ------------");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }
    }

    class University
    {
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", UniversityName, UniversityId);
        }

    }

    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public int StudentAge { get; set; }

        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} " +
              "from University with the Id {4}", StudentName, StudentId, StudentGender, StudentAge, UniversityId);
        }
    }

    
}
