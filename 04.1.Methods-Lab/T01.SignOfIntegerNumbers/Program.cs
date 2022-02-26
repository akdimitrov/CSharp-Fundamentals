using System;

namespace T01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SignOfNum(num));
        }

        private static string SignOfNum(int num)
        {
            string sign = "zero";
            if (num > 0)
            {
                sign = "positive";
            }
            else if (num < 0)
            {
                sign = "negative";
            }

            return $"The number {num} is {sign}.";
        }
    }
}
