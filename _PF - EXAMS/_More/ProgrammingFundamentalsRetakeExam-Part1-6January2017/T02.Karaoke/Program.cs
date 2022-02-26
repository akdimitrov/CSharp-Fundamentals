using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> participantsAwards = new Dictionary<string, List<string>>();
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input;
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string participant = info[0];
                string song = info[1];
                string award = info[2];
                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!participantsAwards.ContainsKey(participant))
                    {
                        participantsAwards[participant] = new List<string>();
                    }
                    if (!participantsAwards[participant].Contains(award))
                    {
                        participantsAwards[participant].Add(award);
                    }
                }
            }

            if (participantsAwards.Count == 0) Console.WriteLine("No awards");
            foreach (var participant in participantsAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                Console.WriteLine(string.Join(Environment.NewLine, participant.Value.OrderBy(x => x).Select(x => $"--{x}")));
            }
        }
    }
}
