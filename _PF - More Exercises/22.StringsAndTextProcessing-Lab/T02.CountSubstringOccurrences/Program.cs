using System;

namespace T02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string key = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(key);
            while (index != -1)
            {
                counter++;
                int startIndex = index + 1;
                index = text.IndexOf(key, startIndex);
            }
            Console.WriteLine(counter);
        }
    }
}
