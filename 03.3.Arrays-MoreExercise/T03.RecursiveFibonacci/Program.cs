using System;

namespace T03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] fibonacciNums = new long[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciNums[i] = 1;
                }
                else
                {
                    fibonacciNums[i] = fibonacciNums[i - 2] + fibonacciNums[i - 1];
                }
            }

            Console.WriteLine(fibonacciNums[n - 1]);
        }
    }
}
