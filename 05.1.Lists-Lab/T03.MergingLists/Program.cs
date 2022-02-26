using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();
            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                if (list1.Count > i)
                {
                    mergedList.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    mergedList.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", mergedList));
        }
    }
}
