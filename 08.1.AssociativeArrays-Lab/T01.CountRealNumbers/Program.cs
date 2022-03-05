using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int number in array)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers[number] = 0;
                }
                numbers[number]++;
            }

            foreach (var pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
