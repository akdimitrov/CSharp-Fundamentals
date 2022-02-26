using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countriesPopulation = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string country = input.Split("|")[1];
                string city = input.Split("|")[0];
                long people = long.Parse(input.Split("|")[2]);
                if (!countriesPopulation.ContainsKey(country))
                {
                    countriesPopulation[country] = new Dictionary<string, long>();
                }
                countriesPopulation[country][city] = people;

                input = Console.ReadLine();
            }

            foreach (var country in countriesPopulation.OrderByDescending(x => x.Value.Sum(x => x.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x => x.Value)})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
