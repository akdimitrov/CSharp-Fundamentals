using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mirrorPairs = new Dictionary<string, string>();
            string text = Console.ReadLine();
            Regex regex = new Regex(@"([@#])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string word = match.Groups["word1"].Value;
                string reversed = string.Join("", match.Groups["word1"].Value.ToString().ToCharArray().Reverse());
                if (match.Groups["word2"].Value == reversed)
                {
                    mirrorPairs[word] = reversed;
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (mirrorPairs.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorPairs.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}
