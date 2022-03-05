using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string user = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                }
                if (!contests[contest].ContainsKey(user) || contests[contest][user] < points)
                {
                    contests[contest][user] = points;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> statistics = new Dictionary<string, int>();
            int position = 1;
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position++}. {user.Key} <::> {user.Value}");
                    if (!statistics.ContainsKey(user.Key))
                    {
                        statistics[user.Key] = 0;
                    }
                    statistics[user.Key] += user.Value;
                }
                position = 1;
            }

            Console.WriteLine("Individual standings:");
            foreach (var user in statistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position++}. {user.Key} -> {user.Value}");
            }
        }
    }
}
