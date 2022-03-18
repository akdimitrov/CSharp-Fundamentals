using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T05.NetherRealms
{
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }

        public double Health { get; set; }

        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDemons = Console.ReadLine()
                    .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Regex healthPattern = new Regex(@"[^\d+\-*/.]");
            Regex numberPattern = new Regex(@"\-?\d+(\.\d+)?");
            Regex mathOperators = new Regex(@"[/*]");
            List<Demon> demons = new List<Demon>();
            foreach (var demon in inputDemons)
            {
                int health = healthPattern.Matches(demon).Sum(x => char.Parse(x.Value));
                double damage = numberPattern.Matches(demon).Sum(x => double.Parse(x.Value));
                List<char> math = demon.Where(x => x == '*' || x == '/').ToList();
                foreach (Match item in mathOperators.Matches(demon))
                {
                    damage = item.Value == "*" ? damage *= 2 : damage /= 2.0;
                }

                demons.Add(new Demon(demon, health, damage));
            }

            foreach (var demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
