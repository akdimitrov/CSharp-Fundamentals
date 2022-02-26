using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);
                students.Add(new Student(firstName, lastName, grade));
            }

            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }
    }
}
