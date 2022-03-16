using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> topNumbers = array.Where(x => x > array.Average()).OrderByDescending(x => x).Take(5).ToList();
            Console.WriteLine(topNumbers.Count > 0 ? string.Join(" ", topNumbers) : "No");
        }
    }
}
