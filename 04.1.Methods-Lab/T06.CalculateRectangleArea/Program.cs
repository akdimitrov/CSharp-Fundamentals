using System;

namespace T06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateRectangleArea(a, b));
        }

        private static double CalculateRectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}
