using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string model, string color, int power, string type)
        {
            Model = model;
            Color = color;
            Horsepower = power;
            Type = type;
        }
        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public string Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] array = input.Split();
                string type = array[0].ToUpper()[0] + array[0].Substring(1).ToLower();
                string model = array[1];
                string color = array[2];
                int horsepower = int.Parse(array[3]);
                Vehicle vehicle = new Vehicle(model, color, horsepower, type);
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            string wanted = Console.ReadLine();
            while (wanted != "Close the Catalogue")
            {
                if (vehicles.Any(x => x.Model == wanted))
                {
                    var car = vehicles.First(x => x.Model == wanted);
                    Console.WriteLine($"Type: {car.Type}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.Horsepower}");
                }

                wanted = Console.ReadLine();
            }

            double carsAverage = 0;
            double trucksAverage = 0;
            if (vehicles.Any(x => x.Type == "Car"))
            {
                carsAverage = vehicles.Where(x => x.Type == "Car").Average(x => x.Horsepower);
            }
            if (vehicles.Any(x => x.Type == "Truck"))
            {
                trucksAverage = vehicles.Where(x => x.Type == "Truck").Average(x => x.Horsepower);
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }
}
