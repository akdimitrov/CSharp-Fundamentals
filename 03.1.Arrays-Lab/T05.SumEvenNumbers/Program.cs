using System;
using System.Linq;

namespace T05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(array.Sum());
        }
    }
}
