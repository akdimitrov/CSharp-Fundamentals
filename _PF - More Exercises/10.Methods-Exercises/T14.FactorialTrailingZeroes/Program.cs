using System;
using System.Numerics;

namespace T14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger zeroes = TrailingZeroes(Factorial(n));
            Console.WriteLine(zeroes);
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        static BigInteger TrailingZeroes(BigInteger fact)
        {
            BigInteger zeroes = 0;
            while (fact % 10 == 0)
            {
                zeroes++;
                fact /= 10;
            }

            return zeroes;
        }
    }
}
