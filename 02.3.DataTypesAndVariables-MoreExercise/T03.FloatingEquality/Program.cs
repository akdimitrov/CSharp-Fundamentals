using System;

namespace T03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Eps = 0.000001f;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            bool isEqual = Math.Abs(num1 - num2) < Eps;
            Console.WriteLine(isEqual);
        }
    }
}
