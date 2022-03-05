using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] info = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = info[0];
                string student = info[1];
                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }
                courses[course].Add(student);

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.WriteLine(string.Join(Environment.NewLine, course.Value.Select(x => $"-- {x}")));
            }
        }
    }
}
