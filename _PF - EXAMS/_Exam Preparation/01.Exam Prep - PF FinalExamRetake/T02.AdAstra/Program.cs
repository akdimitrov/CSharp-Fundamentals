using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([#|])(?<item>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<cal>\d{1,5})\1");
            MatchCollection matches = regex.Matches(input);
            int totalCalories = matches.Sum(x => int.Parse(x.Groups["cal"].Value));
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["cal"]}");
            }
        }
    }
}
