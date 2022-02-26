using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.AverageGrades
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                Student student = new Student(name);
                for (int j = 1; j < input.Length; j++)
                {
                    student.Grades.Add(double.Parse(input[j]));
                }
                students.Add(student);
            }

            foreach (var student in students)
            {
                student.AverageGrade = student.Grades.Average();
            }
            students = students.OrderBy(n => n.Name).ThenByDescending(n => n.AverageGrade).ToList();
            foreach (var student in students)
            {
                if (student.AverageGrade >= 5)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
                }
            }
        }
    }
}
