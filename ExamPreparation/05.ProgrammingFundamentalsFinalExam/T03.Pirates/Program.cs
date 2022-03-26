using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] cityInfo = input.Split("||");
                string city = cityInfo[0];
                int population = int.Parse(cityInfo[1]);
                int gold = int.Parse(cityInfo[2]);

                if (!cities.ContainsKey(city))
                {
                    cities[city] = new int[2];
                }

                cities[city][0] += population;
                cities[city][1] += gold;
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split("=>");
                string city = tokens[1];

                if (tokens[0] == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                    cities[city][0] -= people;
                    cities[city][1] -= gold;
                    if (cities[city][0] <= 0 || cities[city][1] <= 0)
                    {
                        cities.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }

                }
                else if (tokens[0] == "Prosper")
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city][1]} gold.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(!cities.Any() ? "Ahoy, Captain! All targets have been plundered and destroyed!"
                : $"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
            }
        }
    }
}
