using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TraveledDistance { get; set; }

        public void DriveCar(double distance)
        {
            if (distance * FuelConsumptionPerKm <= FuelAmount)
            {
                FuelAmount -= distance * FuelConsumptionPerKm;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double consumption = double.Parse(carInfo[2]);
                Cars.Add(new Car(model, fuel, consumption));
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                string model = command[1];
                double distance = double.Parse(command[2]);
                Cars.First(x => x.Model == model).DriveCar(distance);

                input = Console.ReadLine();
            }

            foreach (var car in Cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
