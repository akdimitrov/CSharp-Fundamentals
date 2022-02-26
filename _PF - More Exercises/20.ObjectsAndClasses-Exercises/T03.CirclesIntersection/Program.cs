using System;
using System.Linq;

namespace T03.CirclesIntersection
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
    }

    class Circle
    {
        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }
        public Point Center { get; set; }

        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle1 = new Circle(new Point(array1[0], array1[1]), array1[2]);
            Circle circle2 = new Circle(new Point(array2[0], array2[1]), array2[2]);
            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(Circle circle1, Circle circle2)
        {
            int a = circle1.Center.X - circle2.Center.X;
            int b = circle1.Center.Y - circle2.Center.Y;
            double distance = Math.Sqrt(a * a + b * b);
            if (distance > circle1.Radius + circle2.Radius)
            {
                return false;
            }
            return true;
        }
    }
}
