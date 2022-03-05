using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.DragonArmy
{
    class Dragon
    {
        public Dragon(int damage, int health, int armor)
        {
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dragon>> dragonArmy = new Dictionary<string, Dictionary<string, Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                int damage = input[2] == "null" ? 45 : int.Parse(input[2]);
                int health = input[3] == "null" ? 250 : int.Parse(input[3]);
                int armor = input[4] == "null" ? 10 : int.Parse(input[4]);

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy[type] = new Dictionary<string, Dragon>();
                }
                dragonArmy[type][name] = new Dragon(damage, health, armor);
            }

            foreach (var type in dragonArmy)
            {
                double damage = type.Value.Values.Select(x => x.Damage).Average();
                double health = type.Value.Values.Select(x => x.Health).Average();
                double armor = type.Value.Values.Select(x => x.Armor).Average();
                Console.WriteLine($"{type.Key}::({damage:f2}/{health:f2}/{armor:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }
}
