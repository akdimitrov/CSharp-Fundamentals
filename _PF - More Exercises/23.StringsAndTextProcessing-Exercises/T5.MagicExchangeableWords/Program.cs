using System;
using System.Collections.Generic;
using System.Linq;

namespace T5.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];
            Console.WriteLine(AreExchangeable(word1, word2).ToString().ToLower());
        }

        private static bool AreExchangeable(string word1, string word2)
        {
            List<char> word1Chars = new List<char>(word1).Distinct().ToList();
            List<char> word2Chars = new List<char>(word2).Distinct().ToList();

            if (word1Chars.Count != word2Chars.Count)
            {
                return false;
            }
            return true;
        }
    }
}
