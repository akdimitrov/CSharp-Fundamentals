using System;

namespace T07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = CalcNumToPower(number, power);
            Console.WriteLine(result);
        }

        private static double CalcNumToPower(double number, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
