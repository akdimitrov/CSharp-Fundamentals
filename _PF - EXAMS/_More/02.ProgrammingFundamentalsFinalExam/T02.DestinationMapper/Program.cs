using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            Regex regex = new Regex(@"([=\/])(?<place>[A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = regex.Matches(places);
            int points = matches.Sum(x => x.Groups["place"].Value.Length);
            Console.WriteLine($"Destinations: {String.Join(", ", matches.Select(x => x.Groups["place"]))}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
