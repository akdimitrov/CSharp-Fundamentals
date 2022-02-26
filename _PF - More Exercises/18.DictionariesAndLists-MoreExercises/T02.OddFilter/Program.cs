using System;
using System.Linq;

namespace T02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(String.Join(" ", array.Select(x => x <= array.Average() ? x - 1 : x + 1)));
        }
    }
}
