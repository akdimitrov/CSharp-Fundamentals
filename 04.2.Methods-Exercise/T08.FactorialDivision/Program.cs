using System;

namespace T08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = FactorialDivision(num1, num2);
            Console.WriteLine("{0:f2}", result);
        }

        private static double FactorialDivision(int num1, int num2)
        {
            return (double)Factorial(num1) / Factorial(num2);
        }

        private static double Factorial(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
