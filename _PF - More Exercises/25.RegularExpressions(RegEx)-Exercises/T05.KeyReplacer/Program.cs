using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Match keys = Regex.Match(Console.ReadLine(), @"([A-Za-z]+)[\|\\<]*.*[\|\\<]+([A-Za-z]+)");
            MatchCollection matches = Regex.Matches(Console.ReadLine(), $@"{keys.Groups[1]}(.*?){keys.Groups[2]}");
            Console.WriteLine(matches.Any(x => x.Length > 0) ? String.Join("", matches.Select(x => x.Groups[1].Value)) : "Empty result");
        }
    }
}
