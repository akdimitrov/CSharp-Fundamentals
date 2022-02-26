using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public string GetType()
        {
            if (Type == "car")
            {
                return "Car";
            }
            return "Truck";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string type = info[0].ToLower();
                string model = info[1];
                string color = info[2];
                int hp = int.Parse(info[3]);
                catalogue.Add(new Vehicle(type, model, color, hp));

                input = Console.ReadLine();
            }

            string vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                var current = catalogue.FirstOrDefault(x => x.Model == vehicleModel);
                if (current != null)
                {
                    Console.WriteLine($"Type: {current.GetType()}");
                    Console.WriteLine($"Model: {current.Model}");
                    Console.WriteLine($"Color: {current.Color}");
                    Console.WriteLine($"Horsepower: {current.HorsePower}");
                }

                vehicleModel = Console.ReadLine();
            }

            double carsAverageHp = catalogue.Any(x => x.Type == "car") ? catalogue.FindAll(x => x.Type == "car").Average(x => x.HorsePower) : 0;
            double trucksAverageHp = catalogue.Any(x => x.Type == "truck") ? catalogue.FindAll(x => x.Type == "truck").Average(x => x.HorsePower) : 0;
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHp:f2}.");
        }
    }
}
