using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            List<int> result = new List<int>();
            List<int> range = new List<int>();

            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    range.Add(i < list1.Count ? list1[i] : list2[i]);
                }
                else
                {
                    result.Add(list1[i]);
                    result.Add(list2[i]);
                }
            }

            result.Sort();
            range.Sort();
            Console.WriteLine(String.Join(" ", result.Where(x => x > range[0] && x < range[1])));
        }
    }

}
