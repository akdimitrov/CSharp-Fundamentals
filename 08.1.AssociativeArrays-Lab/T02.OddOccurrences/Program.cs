using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }
                words[word]++;
            }
            Console.WriteLine(string.Join(" ", words.Where(x => x.Value % 2 != 0).Select(x => x.Key)));
        }
    }
}
