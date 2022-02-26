using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.SupermarketDatabase
{
    class Product
    {
        public Product(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input = Console.ReadLine();
            while (input != "stocked")
            {
                string[] array = input.Split();
                string name = array[0];
                double price = double.Parse(array[1]);
                double quantity = double.Parse(array[2]);
                if (!products.ContainsKey(name))
                {
                    products[name] = new Product(price, quantity);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key}: ${product.Value.Price:F2} * {product.Value.Quantity} = ${product.Value.TotalPrice():F2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${products.Sum(x => x.Value.TotalPrice()):F2}");
        }
    }
}
