using System;

namespace T02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestPoint(x1, y1, x2, y2);
        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (x1 * x1 + y1 * y1 <= x2 * x2 + y2 * y2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
