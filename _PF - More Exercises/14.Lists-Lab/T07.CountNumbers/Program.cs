using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            while (list.Count > 0)
            {
                int counter = 1;
                int num = list[0];
                for (int j = 1; j < list.Count; j++)
                {
                    if (num == list[j])
                    {
                        counter++;
                    }
                }
                list.RemoveAll(el => el == num);
                Console.WriteLine($"{num} -> {counter}");
            }
        }
    }
}
