using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordsOccurances = new Dictionary<string, int>();
            foreach (var word in array)
            {
                if (!wordsOccurances.ContainsKey(word))
                {
                    wordsOccurances[word] = 0;
                }
                wordsOccurances[word]++;
            }

            wordsOccurances = wordsOccurances.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(String.Join(", ", wordsOccurances.Keys));
        }
    }
}
