using System;

namespace T05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            GetOrderPrice(product, quantity);
        }

        private static void GetOrderPrice(string product, double quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
            }
            Console.WriteLine($"{quantity * price:f2}");
        }
    }
}
