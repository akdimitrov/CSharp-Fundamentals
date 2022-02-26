using System;

namespace T03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialBudget = double.Parse(Console.ReadLine());
            double budget = initialBudget;
            string game = Console.ReadLine();
            while (game != "Game Time")
            {
                double price = 0;
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default: Console.WriteLine("Not Found"); game = Console.ReadLine(); continue;
                }
                if (price != 0 && price <= budget)
                {
                    Console.WriteLine($"Bought {game}");
                    budget -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${initialBudget - budget:f2}. Remaining: ${budget:f2}");
        }
    }
}
