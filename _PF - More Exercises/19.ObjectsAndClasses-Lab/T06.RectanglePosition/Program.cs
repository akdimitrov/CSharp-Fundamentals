using System;
using System.Linq;

namespace T06.RectanglePosition
{
    class Rectangle
    {
        public Rectangle(int[] array)
        {
            X = array[0];
            Y = array[1];
            Width = array[2];
            Height = array[3];
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle firstRectangle = new Rectangle(array1);
            Rectangle secondRectangle = new Rectangle(array2);
            PrintRectanglePosition(firstRectangle, secondRectangle);
        }

        static void PrintRectanglePosition(Rectangle a, Rectangle b)
        {
            string position = "Not inside";
            if (a.X >= b.X && a.Y <= b.Y &&
                a.X + a.Width <= b.X + b.Width &&
                a.Y + a.Height <= b.Y + b.Height)
            {
                position = "Inside";
            }

            Console.WriteLine(position);
        }
    }
}
