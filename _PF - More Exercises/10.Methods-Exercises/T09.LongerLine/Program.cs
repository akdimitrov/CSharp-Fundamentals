using System;

namespace T09.LongerLine
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

            double length1 = GetLineLength(x1, y1, x2, y2);
            double length2 = GetLineLength(x3, y3, x4, y4);

            if (length1 >= length2)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }

        }
        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Abs(x1) + Math.Abs(y1);
            double point2 = Math.Abs(x2) + Math.Abs(y2);
            return point1 + point2;
        }

        static void PrintLine(double x1, double y1, double x2, double y2)
        {
            string line = "";
            double point1 = Math.Abs(x1) + Math.Abs(y1);
            double point2 = Math.Abs(x2) + Math.Abs(y2);
            if (point1 <= point2)
            {
                line = $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                line = $"({x2}, {y2})({x1}, {y1})";
            }

            Console.WriteLine(line);
        }
    }
}
