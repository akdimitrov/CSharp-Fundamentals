using System;

namespace T06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(ulong n)
        {
            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (ulong i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
