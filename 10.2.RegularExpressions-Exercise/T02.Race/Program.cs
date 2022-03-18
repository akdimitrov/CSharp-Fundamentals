using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> raceStats = new Dictionary<string, int>();
            foreach (var participant in participants)
            {
                raceStats[participant] = 0;
            }

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string name = string.Join("", Regex.Matches(input, @"[A-Za-z]"));
                int distance = input.Where(x => char.IsDigit(x)).Sum(x => (x - '0'));
                if (raceStats.ContainsKey(name))
                {
                    raceStats[name] += distance;
                }

                input = Console.ReadLine();
            }

            var top3 = raceStats.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"1st place: {top3.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {top3.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {top3.Keys.ElementAt(2)}");
        }
    }
}
