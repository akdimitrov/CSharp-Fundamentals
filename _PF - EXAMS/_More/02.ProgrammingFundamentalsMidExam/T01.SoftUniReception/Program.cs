using System;

namespace T01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = 0;
            while (students > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }

                students -= employee1 + employee2 + employee3;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
