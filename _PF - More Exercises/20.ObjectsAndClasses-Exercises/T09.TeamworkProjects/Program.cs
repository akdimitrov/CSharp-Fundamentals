using System;
using System.Collections.Generic;
using System.Linq;

namespace T09.TeamworkProjects
{
    class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Members = new List<string>();
        }
        public string Creator { get; set; }

        public string Name { get; set; }

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
                string[] array = Console.ReadLine().Split("-");
                string creator = array[0];
                string name = array[1];
                if (teams.Any(team => team.Name == name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creator, name);
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] array = input.Split("->");
                string user = array[0];
                string teamToJoin = array[1];
                if (teams.Any(team => team.Name == teamToJoin))
                {
                    if (teams.Any(team => team.Members.Contains(user)) || teams.Any(team => team.Creator == user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        var teamToUpdate = teams.First(team => team.Name == teamToJoin);
                        teamToUpdate.Members.Add(user);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                input = Console.ReadLine();
            }

            List<Team> teamsToDisband = teams.Where(t => t.Members.Count == 0).ToList();
            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).ToList();

            foreach (var team in validTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband.OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
