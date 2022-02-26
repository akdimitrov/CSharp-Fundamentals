using System;

namespace T02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            PrintVowelsCount(input);
        }

        private static void PrintVowelsCount(string input)
        {
            int count = 0;
            foreach (var item in input)
            {
                if ("aeiou".Contains(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
