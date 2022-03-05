using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string passwords = tokens[1];
                contests[contest] = passwords;
                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            string submission = Console.ReadLine();
            while (submission != "end of submissions")
            {
                string[] tokens = submission.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!submissions.ContainsKey(user))
                    {
                        submissions[user] = new Dictionary<string, int>();
                    }
                    if (!submissions[user].ContainsKey(contest) || submissions[user][contest] < points)
                    {
                        submissions[user][contest] = points;
                    }
                }

                submission = Console.ReadLine();
            }

            var bestStudent = submissions.OrderByDescending(x => x.Value.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking: ");
            foreach (var student in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
