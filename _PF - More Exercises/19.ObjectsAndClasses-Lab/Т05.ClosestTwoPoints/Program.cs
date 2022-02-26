using System;
using System.Collections.Generic;
using System.Linq;

namespace Т05.ClosestTwoPoints
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = array[0];
                int y = array[1];
                Point point = new Point(x, y);
                points.Add(point);
            }

            FindClosestPoints(points);
        }

        static double CalcDistance(Point a, Point b)
        {
            int side1 = a.X - b.X;
            int side2 = a.Y - b.Y;
            return Math.Sqrt(side1 * side1 + side2 * side2);
        }

        static void FindClosestPoints(List<Point> points)
        {
            double shortestDistance = double.MaxValue;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);
                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        index1 = i;
                        index2 = j;
                    }
                }
            }

            if (shortestDistance == double.MaxValue)
            {
                shortestDistance = 0;
            }

            Console.WriteLine($"{shortestDistance:f3}");
            Console.WriteLine(points[index1]);
            Console.WriteLine(points[index2]);
        }
    }
}
