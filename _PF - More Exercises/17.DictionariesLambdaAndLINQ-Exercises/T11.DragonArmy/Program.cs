using System;
using System.Collections.Generic;
using System.Linq;

namespace T11.DragonArmy
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
            Dictionary<string, Dictionary<string, Dragon>> dragons = new Dictionary<string, Dictionary<string, Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int damage = input[2] != "null" ? int.Parse(input[2]) : 45;
                int health = input[3] != "null" ? int.Parse(input[3]) : 250;
                int armor = input[4] != "null" ? int.Parse(input[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new Dictionary<string, Dragon>();
                }
                dragons[type][name] = new Dragon(damage, health, armor);
            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(x => x.Value.Damage):f2}/{type.Value.Average(x => x.Value.Health):f2}/{type.Value.Average(x => x.Value.Armor):f2})");
                Console.WriteLine(String.Join("\n", type.Value.OrderBy(x => x.Key).Select(x => $"-{x.Key} -> damage: {x.Value.Damage}, health: {x.Value.Health}, armor: {x.Value.Armor}")));
            }
        }
    }
}
