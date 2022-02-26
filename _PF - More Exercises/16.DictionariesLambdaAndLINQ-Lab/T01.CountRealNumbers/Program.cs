using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Dictionary<double, int> numberPairs = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!numberPairs.ContainsKey(number))
                {
                    numberPairs[number] = 0;
                }
                numberPairs[number]++;
            }

            foreach (var pair in numberPairs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
