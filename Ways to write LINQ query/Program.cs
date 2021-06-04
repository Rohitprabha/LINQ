using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Example_2
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> listStudents = new List<Student>();
            Student s1 = new Student
            {
                ID = 101,
                Name = "Rohit",
                Gender = "Male"
            };
            listStudents.Add(s1);
            Student s2 = new Student
            {
                ID = 102,
                Name = "John",
                Gender = "Male"
            };
            listStudents.Add(s2);
            Student s3 = new Student
            {
                ID = 103,
                Name = "Mary",
                Gender = "Female"
            };
            listStudents.Add(s3);
            return listStudents;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Student.GetStudents().Where(Stds => Stds.Gender == "Male");         //using Lambda Expressions.
            foreach (Student item in students)
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.Gender);
            }

            Console.WriteLine();

            IEnumerable<Student> student = from std in Student.GetStudents() where std.Gender == "Male" select std;         //using SQL like Query Expression.
            foreach (Student item in student)
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.Gender);
            }
            Console.ReadKey();
        }
    }
}
