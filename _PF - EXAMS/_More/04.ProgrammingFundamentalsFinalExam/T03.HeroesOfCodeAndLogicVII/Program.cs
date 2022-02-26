using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }
        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = heroInfo[0];
                int hitPoints = int.Parse(heroInfo[1]);
                int manaPoints = int.Parse(heroInfo[2]);
                heroes.Add(new Hero(name, hitPoints, manaPoints));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                var hero = heroes.First(x => x.Name == cmd[1]);
                if (action == "CastSpell")
                {
                    int manaNeeded = int.Parse(cmd[2]);
                    if (hero.ManaPoints >= manaNeeded)
                    {
                        hero.ManaPoints -= manaNeeded;
                        Console.WriteLine($"{hero.Name} has successfully cast {cmd[3]} and now has {hero.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} does not have enough MP to cast {cmd[3]}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmd[2]);
                    string attacker = cmd[3];
                    hero.HitPoints -= damage;
                    if (hero.HitPoints > 0)
                    {
                        Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = Math.Min(int.Parse(cmd[2]), 200 - hero.ManaPoints);
                    hero.ManaPoints += amount;
                    Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = Math.Min(int.Parse(cmd[2]), 100 - hero.HitPoints);
                    hero.HitPoints += amount;
                    Console.WriteLine($"{hero.Name} healed for {amount} HP!");
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }
}
