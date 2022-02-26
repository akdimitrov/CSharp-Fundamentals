using System;
using System.Collections.Generic;

namespace T04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Age { get; set; }

        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] info = input.Split();
                string firstName = info[0];
                string lastName = info[1];
                double age = double.Parse(info[2]);
                string homeTown = info[3];
                students.Add(new Student(firstName, lastName, age, homeTown));
                input = Console.ReadLine();
            }

            string city = Console.ReadLine();
            foreach (var student in students.FindAll(x => x.HomeTown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
