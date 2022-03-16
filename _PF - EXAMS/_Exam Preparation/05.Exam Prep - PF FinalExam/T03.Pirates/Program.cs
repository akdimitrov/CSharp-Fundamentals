using System;
using System.Collections.Generic;

namespace T03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long[]> cities = new Dictionary<string, long[]>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] cityInfo = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = cityInfo[0];
                int population = int.Parse(cityInfo[1]);
                int gold = int.Parse(cityInfo[2]);
                if (!cities.ContainsKey(city))
                {
                    cities[city] = new long[] { population, gold };
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmd = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                string town = cmd[1];
                if (action == "Plunder")
                {
                    int people = int.Parse(cmd[2]);
                    int gold = int.Parse(cmd[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    cities[town][0] -= people;
                    cities[town][1] -= gold;
                    if (cities[town][0] == 0 || cities[town][1] == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(cmd[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                }

                command = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
