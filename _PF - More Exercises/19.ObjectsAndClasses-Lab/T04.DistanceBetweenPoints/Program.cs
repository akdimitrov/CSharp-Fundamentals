using System;
using System.Linq;

namespace T04.DistanceBetweenPoints
{
    class Point
    {
        public Point(int[] array)
        {
            X = array[0];
            Y = array[1];
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] point1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point firstPoint = new Point(point1);
            int[] point2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point secondPoint = new Point(point2);
            Console.WriteLine($"{CalcDistance(firstPoint, secondPoint):f3}");

        }

        static double CalcDistance(Point a, Point b)
        {
            double distance = 0;
            int side1 = a.X - b.X;
            int side2 = a.Y - b.Y;
            distance = side1 * side1 + side2 * side2;
            return Math.Sqrt(distance);
        }
    }
}
