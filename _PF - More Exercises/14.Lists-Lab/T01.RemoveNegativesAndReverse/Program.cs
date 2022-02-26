using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.RemoveAll(el => el < 0);
            list.Reverse();
            if (list.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
