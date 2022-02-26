using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                string name = input.Split(": ")[0];
                string[] cards = input.Split(": ")[1].Split(", ");
                if (!players.ContainsKey(name))
                {
                    players[name] = new List<string>();
                }
                players[name].AddRange(cards);
                input = Console.ReadLine();
            }
            foreach (var player in players)
            {
                var cards = player.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in cards)
                {
                    string cardPower = card[0].ToString();
                    char cardtype = card[1];
                    if (card.Length == 3)
                    {
                        cardPower = card[0] + card[1].ToString();
                        cardtype = card[2];
                    }
                    int power = 0;
                    int type = 0;
                    switch (cardPower)
                    {
                        case "J": power = 11; break;
                        case "Q": power = 12; break;
                        case "K": power = 13; break;
                        case "A": power = 14; break;
                        default: power = int.Parse(cardPower); break;
                    }
                    switch (cardtype)
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;
                    }

                    sum += power * type;
                }

                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
