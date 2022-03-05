using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string text = Console.ReadLine();
            foreach (var ch in text.Where(x => x != ' '))
            {
                if (!characters.ContainsKey(ch))
                {
                    characters[ch] = 0;
                }
                characters[ch]++;
            }

            foreach (var item in characters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
