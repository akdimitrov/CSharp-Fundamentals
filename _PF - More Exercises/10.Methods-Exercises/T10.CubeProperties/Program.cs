using System;

namespace T10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            PrintCubeProperties(length, parameter);
        }

        private static void PrintCubeProperties(double length, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(length, 2));
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(length, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(length, 3);
            }
            else if (parameter == "area")
            {
                result = 6 * Math.Pow(length, 2);
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
