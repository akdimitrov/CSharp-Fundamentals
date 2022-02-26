using System;
using System.Linq;

namespace T08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    numbers[j] += numbers[j + 1];
                }
                length--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
