using System;

namespace T01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1Productivity = int.Parse(Console.ReadLine());
            int employee2Productivity = int.Parse(Console.ReadLine());
            int employee3Productivity = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = employee1Productivity + employee2Productivity + employee3Productivity;
            int hours = 0;
            while (students > 0)
            {
                hours++;
                if (hours % 4 != 0)
                {
                    students -= studentsPerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
