using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex datePattern = new Regex(@"\b(?<day>\d{2})([.\-/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matchedDates = datePattern.Matches(Console.ReadLine());
            Console.WriteLine(String.Join("\n", matchedDates.Select(x => $"Day: {x.Groups["day"].Value}, Month: {x.Groups["month"].Value}, Year: {x.Groups["year"].Value}")));
        }
    }
}
