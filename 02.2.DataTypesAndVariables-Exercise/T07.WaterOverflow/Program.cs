using System;

namespace T07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalWater = 0;
            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                totalWater += litres;
                if (totalWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalWater -= litres;
                }
            }
            Console.WriteLine(totalWater);
        }
    }
}
