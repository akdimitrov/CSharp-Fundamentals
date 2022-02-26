using System;
using System.Collections.Generic;

namespace T04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tribonacci = new List<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    tribonacci.Add(1);
                }
                else if (i == 2)
                {
                    tribonacci.Add(2);
                }
                else
                {
                    int num = tribonacci[i - 3] + tribonacci[i - 2] + tribonacci[i - 1];
                    tribonacci.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", tribonacci));
        }
    }
}
