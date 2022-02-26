using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T06.EmailStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            Regex emailPattern = new Regex(@"\b(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}(\.com|\.bg|\.org)\b)");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Match match = emailPattern.Match(Console.ReadLine());
                if (match.Success)
                {
                    string domain = match.Groups["domain"].Value;
                    string username = match.Groups["username"].Value;
                    if (!emails.ContainsKey(domain))
                    {
                        emails[domain] = new List<string>();
                    }

                    if (!emails[domain].Contains(username))
                    {
                        emails[domain].Add(username);
                    }
                }
            }

            foreach (var item in emails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var username in item.Value)
                {
                    Console.WriteLine($"### {username}");
                }
            }
        }
    }
}
