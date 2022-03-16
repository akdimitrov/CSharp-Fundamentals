using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.PlantDiscovery
{
    class Plant
    {
        public Plant(double rarity)
        {
            Rarity = rarity;
            Ratings = new List<double>();
        }
        public double Rarity { get; set; }

        public List<double> Ratings { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                double rarity = double.Parse(info[1]);
                plants[name] = new Plant(rarity);
            }

            string input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] command = input.Split(new char[] { ':', '-', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string plant = command[1];
                if (plants.ContainsKey(plant))
                {
                    if (action == "Rate")
                    {
                        double rating = double.Parse(command[2]);
                        plants[plant].Ratings.Add(rating);
                    }
                    else if (action == "Update")
                    {
                        double rarity = double.Parse(command[2]);
                        plants[plant].Rarity = rarity;
                    }
                    else if (action == "Reset")
                    {
                        plants[plant].Ratings.Clear();
                    }
                }
                else
                {
                    Console.WriteLine($"error");
                }

                input = Console.ReadLine();
            }

            foreach (var item in plants)
            {
                if (item.Value.Ratings.Count == 0)
                {
                    item.Value.Ratings.Add(0);
                }
            }
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.Ratings.Average()))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Ratings.Average():f2}");
            }
        }
    }
}
