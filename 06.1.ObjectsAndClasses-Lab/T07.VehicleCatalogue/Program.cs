using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] info = input.Split('/');
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                double value = double.Parse(info[3]);
                if (type == "Car")
                {
                    catalogue.Cars.Add(new Car(brand, model, value));
                }
                else if (type == "Truck")
                {
                    catalogue.Trucks.Add(new Truck(brand, model, value));
                }

                input = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
