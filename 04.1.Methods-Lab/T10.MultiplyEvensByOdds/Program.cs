using System;

namespace T10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int evenSum = 0;
            int oddSum = 0;
            while (num > 0)
            {
                int currentDigit = num % 10;
                num /= 10;
                if (currentDigit % 2 == 0) evenSum += currentDigit;
                else oddSum += currentDigit;
            }
            return evenSum * oddSum;
        }
    }
}
