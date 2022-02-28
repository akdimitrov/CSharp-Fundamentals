using System;
using System.Linq;

namespace T05.OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            foreach (var number in numbers)
            {
                result = number ^ result;
            }
            Console.WriteLine(result);
        }
    }
}
