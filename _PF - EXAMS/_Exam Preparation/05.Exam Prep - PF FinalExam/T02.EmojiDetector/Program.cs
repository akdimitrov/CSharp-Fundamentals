using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace T02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex emojiPattern = new Regex(@"(::|\*\*)(?<letters>[A-Z][a-z]{2,})\1");
            MatchCollection emojis = emojiPattern.Matches(text);
            BigInteger treshhold = 1;
            foreach (var digit in text.Where(x => char.IsDigit(x)))
            {
                treshhold *= int.Parse(digit.ToString());
            }

            Console.WriteLine($"Cool threshold: {treshhold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine, emojis.Where(x => x.Groups["letters"].Value.Sum(x => x) > treshhold)));
        }
    }
}
