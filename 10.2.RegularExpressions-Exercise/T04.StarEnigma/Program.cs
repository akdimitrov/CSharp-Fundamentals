using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@(?<planet>[A-Za-z]+)[^@\-!:>]*:\d+[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->\d+");
            var planets = new Dictionary<char, SortedSet<string>>()
            {
                ['A'] = new SortedSet<string>(),
                ['D'] = new SortedSet<string>()
            };

            int messages = int.Parse(Console.ReadLine());
            for (int i = 0; i < messages; i++)
            {
                string message = Console.ReadLine();
                int count = Regex.Matches(message, @"(?i)[star]").Count();
                string decrypted = string.Join("", message.Select(x => (char)(x - count)));
                Match match = regex.Match(decrypted);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    char attackType = char.Parse(match.Groups["attack"].Value);
                    planets[attackType].Add(planet);
                }
            }

            Console.WriteLine($"Attacked planets: {planets['A'].Count}");
            foreach (var planet in planets['A'])
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {planets['D'].Count}");
            foreach (var planet in planets['D'])
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
