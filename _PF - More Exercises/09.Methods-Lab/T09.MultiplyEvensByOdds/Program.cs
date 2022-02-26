using System;

namespace T09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultiplyEvensByOdds(number);
            Console.WriteLine(result);
        }

        private static int MultiplyEvensByOdds(int number)
        {
            if (number < 0)
            {
                number = Math.Abs(number);
            }
            int evenSum = 0;
            int oddSum = 0;

            while (number > 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }

                number /= 10;
            }

            return evenSum * oddSum;
        }
    }
}
