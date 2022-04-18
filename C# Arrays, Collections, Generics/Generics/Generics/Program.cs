using Generics;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student
            {
                Name = "Rosa",
                Age = 16,
                Grade = 8.55,
            };

            var student2 = new Student
            {
                Name = "Flavius",
                Age = 15,
                Grade = 9.50,
            };

            var student3 = new Student
            {
                Name = "Gabriel",
                Age = 13,
                Grade = 6.44,
            };

            var student4 = new Student
            {
                Name = "Denis",
                Age = 14,
                Grade = 7.23,
            };


            Collection<Student> _students = new Collection<Student>();
            _students.Add(student1);
            _students.Add(student2);
            _students.Add(student3);
            _students.Add(student4);

            foreach (Student student in _students.GetAll())
            {
                if (student != null)
                {
                    Console.WriteLine(student);

                }

            }

            Console.WriteLine();
            Console.WriteLine(_students.GetStudent(3));
            Console.WriteLine();
            _students.SetStudent(3, student1);
            _students.SwapStudents(0, 2);

            foreach (Student student in _students.GetAll())
            {
                if (student != null)
                {
                    Console.WriteLine(student);

                }
            }

            Console.WriteLine();
            _students.Remove();
            foreach (Student student in _students.GetAll())
            {
                if (student != null)
                {
                    Console.WriteLine(student);
                }

            }
        }
    }
}