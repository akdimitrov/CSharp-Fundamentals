using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = list.Average();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= average)
                {
                    list.RemoveAt(i--);
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                list.Sort();
                list.Reverse();
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                    if (i == 4)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
