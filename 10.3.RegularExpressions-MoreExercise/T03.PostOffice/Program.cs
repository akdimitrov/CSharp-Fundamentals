using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string letters = Regex.Match(input[0], @"([#$%*&])([A-Z]+)\1").Groups[2].Value;
            MatchCollection words = Regex.Matches(input[2], @"\b[A-Z][\S]*\b");
            foreach (var letter in letters)
            {
                Match match = Regex.Match(input[1], $@"({(int)letter}):(\d\d)");
                int length = int.Parse(match.Groups[2].Value) + 1;
                Console.WriteLine(words.First(x => x.Value[0] == letter && x.Length == length));
            }
        }
    }
}
