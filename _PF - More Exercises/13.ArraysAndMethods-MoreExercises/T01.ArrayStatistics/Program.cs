using System;
using System.Linq;

namespace T01.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}
