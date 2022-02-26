using System;

namespace T02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GradeDefinition(grade));
        }

        private static string GradeDefinition(double grade)
        {
            string gradeDefinition = string.Empty;
            if (grade >= 5.50)
            {
                gradeDefinition = "Excellent";
            }
            else if (grade >= 4.50)
            {
                gradeDefinition = "Very good";
            }
            else if (grade >= 3.50)
            {
                gradeDefinition = "Good";
            }
            else if (grade >= 3)
            {
                gradeDefinition = "Poor";
            }
            else if (grade >= 2)
            {
                gradeDefinition = "Fail";
            }
            return gradeDefinition;
        }
    }
}
