using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                int reversed = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    reversed = reversed * 10 + digit;
                    num /= 10;
                }

                list[i] = reversed;
            }

            Console.WriteLine(list.Sum());
        }
    }
}
