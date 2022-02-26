using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> viruses = new Dictionary<string, int>();
            int initialHealth = int.Parse(Console.ReadLine());
            int currentHealth = initialHealth;
            string virus = Console.ReadLine();
            while (virus != "end")
            {
                int strength = virus.ToCharArray().Sum(x => x) / 3;
                int time = strength * virus.Length;
                if (!viruses.ContainsKey(virus))
                {
                    viruses[virus] = 0;
                }
                viruses[virus]++;

                if (viruses[virus] > 1)
                {
                    time /= 3;
                }

                int minutes = time / 60;
                int seconds = time % 60;
                Console.WriteLine($"Virus {virus}: {strength} => {time} seconds");
                if (time <= currentHealth)
                {
                    currentHealth -= time;
                    Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {currentHealth}");
                    currentHealth = (int)Math.Min(initialHealth, currentHealth * 1.2);
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}
