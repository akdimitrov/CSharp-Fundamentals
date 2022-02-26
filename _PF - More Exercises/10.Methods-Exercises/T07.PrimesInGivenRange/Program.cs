using System;
using System.Collections.Generic;

namespace T07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrimeChecker(start, end);
        }

        private static void PrimeChecker(int start, int end)
        {
            List<int> PrimeNums = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    PrimeNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", PrimeNums));
        }
    }
}
