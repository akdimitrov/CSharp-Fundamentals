using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(::|\*\*)([A-Z][a-z]{2,})\1");
            string input = Console.ReadLine();
            MatchCollection emojis = regex.Matches(input);
            long treshold = 1;
            foreach (var digit in input.Where(x => char.IsDigit(x)))
            {
                treshold *= digit - '0';
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match emoji in emojis.Where(x => x.Groups[2].Value.Sum(x => x) > treshold))
            {
                Console.WriteLine(emoji.Value);
            }
        }
    }
}
