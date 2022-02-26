using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.RawData
{
    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }

        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];
                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);
                int weight = int.Parse(info[3]);
                string type = info[4];
                cars.Add(new Car(model, speed, power, weight, type));
            }

            string cargoType = Console.ReadLine();
            var wantedCars = cars.Where(x => x.Cargo.Type == cargoType && x.Cargo.Weight < 1000);
            if (cargoType == "flamable")
            {
                wantedCars = cars.Where(x => x.Cargo.Type == cargoType && x.Engine.Power > 250);
            }

            Console.WriteLine(string.Join(Environment.NewLine, wantedCars.Select(x => x.Model)));
        }
    }
}
