using System;
using System.Numerics;

namespace T01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = meters / 1000m;
            Console.WriteLine($"{km:f2}");
        }
    }
}
