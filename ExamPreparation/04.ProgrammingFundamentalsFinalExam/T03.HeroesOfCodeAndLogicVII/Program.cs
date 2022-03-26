using System;
using System.Collections.Generic;

namespace T03.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string hero = heroInfo[0];
                int hitPoints = int.Parse(heroInfo[1]);
                int manaPoints = int.Parse(heroInfo[2]);
                heroes[hero] = new int[] { hitPoints, manaPoints };
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" - ");
                string action = tokens[0];
                string hero = tokens[1];
                int value = int.Parse(tokens[2]);

                if (action == "CastSpell")
                {
                    if (heroes[hero][1] >= value)
                    {
                        heroes[hero][1] -= value;
                        Console.WriteLine($"{hero} has successfully cast {tokens[3]} and now has {heroes[hero][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {tokens[3]}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    heroes[hero][0] -= value;
                    if (heroes[hero][0] > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {value} HP by {tokens[3]} and now has {heroes[hero][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(hero);
                        Console.WriteLine($"{hero} has been killed by {tokens[3]}!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = Math.Min(value, 200 - heroes[hero][1]);
                    heroes[hero][1] += amount;
                    Console.WriteLine($"{hero} recharged for {amount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = Math.Min(value, 100 - heroes[hero][0]);
                    heroes[hero][0] += amount;
                    Console.WriteLine($"{hero} healed for {amount} HP!");
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
