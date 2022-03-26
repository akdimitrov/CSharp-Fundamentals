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
            Regex regex = new Regex(@"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            var mirrorWords = matches.Where(x => x.Groups[2].Value == string.Join("", x.Groups[3].Value.Reverse()))
                .ToDictionary(x => x.Groups[2].Value, x => x.Groups[3].Value);

            Console.WriteLine(matches.Count > 0 ? $"{matches.Count} word pairs found!" : "No word pairs found!");

            if (mirrorWords.Any())
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords.Select(x => $"{x.Key} <=> {x.Value}")));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
