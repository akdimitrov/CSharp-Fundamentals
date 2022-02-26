using System;

namespace T01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAtt = 0;
            for (int i = 0; i < students; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                double totalBonus = attendances / lectures * (5 + bonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAtt = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAtt} lectures.");
        }
    }
}
