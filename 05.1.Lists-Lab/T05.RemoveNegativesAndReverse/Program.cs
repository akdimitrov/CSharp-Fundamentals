using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0).Reverse().ToList();
            Console.WriteLine(numbers.Count > 0 ? String.Join(" ", numbers) : "empty");
        }
    }
}
