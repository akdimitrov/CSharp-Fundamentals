using System;

namespace T11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = CalcArea(type);
            Console.WriteLine($"{area:f2}");
        }

        private static double CalcArea(string type)
        {
            double area = 0;
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }

            return area;
        }
    }
}
