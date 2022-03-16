using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pianoPieces = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = info[0];
                string composer = info[1];
                string key = info[2];
                pianoPieces[piece] = new List<string>() { composer, key };
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmd = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                string piece = cmd[1];
                if (action == "Add")
                {
                    if (pianoPieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pianoPieces[piece] = new List<string>() { cmd[2], cmd[3] };
                        Console.WriteLine($"{piece} by {cmd[2]} in {cmd[3]} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (pianoPieces.Remove(piece))
                    {
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    if (pianoPieces.ContainsKey(piece))
                    {
                        pianoPieces[piece][1] = cmd[2];
                        Console.WriteLine($"Changed the key of {piece} to {cmd[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in pianoPieces.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
