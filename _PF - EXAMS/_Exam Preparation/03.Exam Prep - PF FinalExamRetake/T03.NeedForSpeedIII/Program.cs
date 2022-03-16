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
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = info[0];
                int mileage = int.Parse(info[1]);
                int fuel = int.Parse(info[2]);
                cars.Add(new Car(car, mileage, fuel));
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmd = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                string car = cmd[1];
                var currentCar = cars.First(x => x.Make == car);
                if (action == "Drive")
                {
                    int distance = int.Parse(cmd[2]);
                    int fuel = int.Parse(cmd[3]);
                    if (currentCar.Fuel >= fuel)
                    {
                        currentCar.Mileage += distance;
                        currentCar.Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (currentCar.Mileage >= 100000)
                        {
                            cars.Remove(currentCar);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(cmd[2]);
                    int refilledAmout = Math.Min(75 - currentCar.Fuel, fuel);
                    currentCar.Fuel += refilledAmout;
                    Console.WriteLine($"{car} refueled with {refilledAmout} liters");
                }
                else if (action == "Revert")
                {
                    int distance = int.Parse(cmd[2]);
                    currentCar.Mileage -= distance;
                    if (currentCar.Mileage < 10000)
                    {
                        currentCar.Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(x => x.Mileage).ThenBy(x => x.Make))
            {
                Console.WriteLine($"{car.Make} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}
