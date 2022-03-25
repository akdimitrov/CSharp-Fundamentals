using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.PlantDiscovery
{
    public class Plant
    {
        public Plant(string name, string rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Ratings = new List<int>();
        }

        public string Name { get; set; }

        public string Rarity { get; set; }

        public List<int> Ratings { get; set; }

        private double AverageRating()
            => Ratings.Any() ? Ratings.Average() : 0;

        public override string ToString()
            => $"- {Name}; Rarity: {Rarity}; Rating: {AverageRating():f2}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                plants.Add(new Plant(plantInfo[0], plantInfo[1]));
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] tokens = command.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Plant plant = plants.FirstOrDefault(x => x.Name == tokens[1]);
                if (plant == null)
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (tokens[0] == "Rate")
                {
                    plant.Ratings.Add(int.Parse(tokens[2]));
                }
                else if (tokens[0] == "Update")
                {
                    plant.Rarity = tokens[2];
                }
                else if (tokens[0] == "Reset")
                {
                    plant.Ratings.Clear();
                }
            }

            Console.WriteLine($"Plants for the exhibition:");
            plants.ForEach(Console.WriteLine);
        }
    }
}
