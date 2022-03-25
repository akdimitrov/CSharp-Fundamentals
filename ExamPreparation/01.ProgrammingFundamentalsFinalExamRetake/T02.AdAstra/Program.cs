using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([#|])(?<product>[A-Za-z ]+)\1(?<date>\d\d\/\d\d\/\d\d)\1(?<cals>\d{1,5})\1");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            int days = matches.Sum(x => int.Parse(x.Groups["cals"].Value)) / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["product"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["cals"].Value}");
            }
        }
    }
}
