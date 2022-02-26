using System;

namespace T05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibNum = GetFibNum(n);
            Console.WriteLine(fibNum);
        }

        private static int GetFibNum(int n)
        {
            int fibNum = 0;
            int last = 0;
            int prev = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    fibNum = 1;

                }
                else
                {
                    fibNum = last + prev;
                }

                prev = last;
                last = fibNum;
            }

            return fibNum;
        }
    }
}
