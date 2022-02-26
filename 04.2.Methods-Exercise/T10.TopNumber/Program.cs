using System;

namespace T10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }

        private static void PrintTopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = DigitsSum(i);
                if (HasOddDigit(i) && (sum % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int DigitsSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static bool HasOddDigit(int n)
        {
            while (n > 0)
            {
                if (n % 10 % 2 != 0)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
        }
    }
}
