using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.NeedForSpeedIII
{
    class Car
    {
        public Car(string make, int mileage, int fuel)
        {
            Make = make;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Make { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }

        public override string ToString()
            => $"{Make} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');
                string make = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                cars.Add(new Car(make, mileage, fuel));
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] tokens = command.Split(" : ");
                Car car = cars.First(x => x.Make == tokens[1]);

                if (tokens[0] == "Drive")
                {
                    Drive(cars, car, int.Parse(tokens[2]), int.Parse(tokens[3]));
                }
                else if (tokens[0] == "Refuel")
                {
                    Refuel(car, int.Parse(tokens[2]));
                }
                else if (tokens[0] == "Revert")
                {
                    Revert(car, int.Parse(tokens[2]));
                }

                command = Console.ReadLine();
            }

            cars.ForEach(Console.WriteLine);
        }

        static void Drive(List<Car> cars, Car car, int distance, int fuel)
        {
            if (car.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            car.Mileage += distance;
            car.Fuel -= fuel;
            Console.WriteLine($"{car.Make} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (car.Mileage >= 100000)
            {
                cars.Remove(car);
                Console.WriteLine($"Time to sell the {car.Make}!");
            }
        }

        static void Refuel(Car car, int fuel)
        {
            int amount = Math.Min(fuel, 75 - car.Fuel);
            car.Fuel += amount;
            Console.WriteLine($"{car.Make} refueled with {amount} liters");
        }

        static void Revert(Car car, int kilometers)
        {
            car.Mileage -= kilometers;
            if (car.Mileage < 10000)
            {
                car.Mileage = 10000;
                return;
            }

            Console.WriteLine($"{car.Make} mileage decreased by {kilometers} kilometers");
        }
    }
}
