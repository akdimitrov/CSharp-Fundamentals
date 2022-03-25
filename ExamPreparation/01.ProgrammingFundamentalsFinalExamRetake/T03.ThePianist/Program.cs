using System;
using System.Collections.Generic;

namespace T03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split('|');
                pieces[pieceInfo[0]] = new string[] { pieceInfo[1], pieceInfo[2] };
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split('|');
                string command = tokens[0];
                string piece = tokens[1];

                if (command == "Add")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        continue;
                    }

                    string composer = tokens[2];
                    string key = tokens[3];
                    pieces[piece] = new string[] { composer, key };
                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
                else if (command == "Remove")
                {
                    Console.WriteLine(pieces.Remove(piece) ? $"Successfully removed {piece}!"
                        : $"Invalid operation! {piece} does not exist in the collection.");
                }
                else if (command == "ChangeKey")
                {
                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        continue;
                    }

                    string newKey = tokens[2];
                    pieces[piece][1] = newKey;
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
