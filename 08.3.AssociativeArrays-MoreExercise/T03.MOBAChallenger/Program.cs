using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players =
                new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Season end")
            {
                string[] tokens = input.Split(" -> ");
                if (tokens.Length > 1)
                {
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);
                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>();
                    }
                    if (!players[player].ContainsKey(position) || players[player][position] < skill)
                    {
                        players[player][position] = skill;
                    }

                    input = Console.ReadLine();
                    continue;
                }

                string[] duelInfo = input.Split(" vs ");
                string player1 = duelInfo[0];
                string player2 = duelInfo[1];
                if (players.ContainsKey(player1) && players.ContainsKey(player2))
                {
                    if (players[player1].Keys.Any(x => players[player2].ContainsKey(x)))
                    {
                        if (players[player1].Values.Sum() < players[player2].Values.Sum())
                        {
                            players.Remove(player1);
                        }
                        else if (players[player1].Values.Sum() > players[player2].Values.Sum())
                        {
                            players.Remove(player2);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
