using System;

namespace T03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": AddNumbers(num1, num2); break;
                case "multiply": MultiplyNumbers(num1, num2); break;
                case "subtract": SubtractNumbers(num1, num2); break;
                case "divide": DivideNumbers(num1, num2); break;
            }
        }

        static void AddNumbers(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void MultiplyNumbers(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void SubtractNumbers(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void DivideNumbers(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
