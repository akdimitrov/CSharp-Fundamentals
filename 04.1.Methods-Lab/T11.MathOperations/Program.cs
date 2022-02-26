using System;

namespace T11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double SecondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(MathOperations(firstNum, SecondNum, operation));
        }

        private static double MathOperations(double firstNum, double secondNum, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '/': result = firstNum / secondNum; break;
                case '*': result = firstNum * secondNum; break;
                case '+': result = firstNum + secondNum; break;
                case '-': result = firstNum - secondNum; break;
            }
            return result;
        }
    }
}
