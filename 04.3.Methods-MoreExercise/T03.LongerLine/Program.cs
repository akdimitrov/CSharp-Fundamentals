using System;

namespace T03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1Length = LineLength(x1, y1, x2, y2);
            double line2Length = LineLength(x3, y3, x4, y4);
            if (line1Length >= line2Length)
            {
                PrintOrderedPoints(x1, y1, x2, y2);
            }
            else
            {
                PrintOrderedPoints(x3, y3, x4, y4);
            }
        }

        private static double LineLength(double x1, double y1, double x2, double y2)
        {
            double point1 = x1 * x1 + y1 * y1;
            double point2 = x2 * x2 + y2 * y2;
            return point1 + point2;
        }


        static void PrintOrderedPoints(double x1, double y1, double x2, double y2)
        {
            if (x1 * x1 + y1 * y1 <= x2 * x2 + y2 * y2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
