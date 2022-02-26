using System;
using System.Linq;

namespace T02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|");
            int health = 100;
            int bitcoins = 0;
            for (int i = 0; i < array.Length; i++)
            {
                string[] command = array[i].Split();
                if (command[0] == "potion")
                {
                    int lastHealth = health;
                    health = Math.Min(100, health + int.Parse(command[1]));
                    Console.WriteLine($"You healed for {health - lastHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command[0] == "chest")
                {
                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {int.Parse(command[1])} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
