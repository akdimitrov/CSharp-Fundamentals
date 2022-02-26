using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace T10.StudentGroups
{
    class Student
    {
        public Student(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            RegistrationDate = date;
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public Town(string name, int size)
        {
            Name = name;
            GroupSize = size;
            Students = new List<Student>();
        }
        public string Name { get; set; }

        public int GroupSize { get; set; }

        public List<Student> Students { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] line = input.Split(" => ");
                if (line.Length == 2)
                {
                    string townName = line[0];
                    string[] second = line[1].Split();
                    int groupSize = int.Parse(second[0]);
                    if (groupSize > 0)
                    {
                        Town town = new Town(townName, groupSize);
                        towns.Add(town);
                    }
                }
                else
                {
                    string[] studentInfo = input.Split("|");
                    string studentName = studentInfo[0].Trim();
                    string email = studentInfo[1].Trim();
                    string date = studentInfo[2].Trim();
                    DateTime regDate = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student(studentName, email, regDate);
                    towns[towns.Count - 1].Students.Add(student);
                }

                input = Console.ReadLine();
            }

            double groups = 0;
            foreach (var town in towns)
            {
                groups += Math.Ceiling(1.0 * town.Students.Count / town.GroupSize);
            }
            Console.WriteLine($"Created {groups} groups in {towns.Count} towns:");


            foreach (var town in towns.OrderBy(t => t.Name))
            {
                Console.Write($"{town.Name} => ");
                int counter = 0;
                foreach (var student in town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email))
                {
                    counter++;
                    if (counter > town.GroupSize)
                    {
                        Console.WriteLine();
                        Console.Write($"{town.Name} => {student.Email}");
                        counter = 1;
                    }
                    else
                    {
                        if (counter == 1)
                        {
                            Console.Write($"{student.Email}");
                        }
                        else
                        {
                            Console.Write($", {student.Email}");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

