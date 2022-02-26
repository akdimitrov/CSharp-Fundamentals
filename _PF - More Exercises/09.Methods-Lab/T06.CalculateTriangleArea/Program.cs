using System;

namespace T06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double CalculateTriangleArea(double width, double height)
        {
            double area = width * height / 2;
            return area;
        }
    }
}
