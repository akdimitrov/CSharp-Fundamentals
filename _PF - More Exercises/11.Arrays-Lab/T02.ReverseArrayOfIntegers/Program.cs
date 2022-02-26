using System;

namespace T02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
