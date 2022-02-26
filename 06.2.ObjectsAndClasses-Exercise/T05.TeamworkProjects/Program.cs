using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string team = input[1];
                if (teams.Any(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(team, creator));
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
            }

            string assignment = Console.ReadLine();
            while (assignment != "end of assignment")
            {
                string[] info = assignment.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = info[0];
                string team = info[1];
                var currentTeam = teams.FirstOrDefault(x => x.TeamName == team);
                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(member)) || teams.Any(x => x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else
                {
                    currentTeam.Members.Add(member);
                }

                assignment = Console.ReadLine();
            }

            var validTeams = teams.Where(x => x.Members.Count > 0).ToList();
            var teamsToDisband = teams.Where(x => x.Members.Count == 0).ToList();
            foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.OrderBy(x => x).Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband.OrderBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
