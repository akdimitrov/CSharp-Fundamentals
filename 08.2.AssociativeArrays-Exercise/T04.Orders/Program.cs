using System;
using System.Collections.Generic;

namespace T04.Orders
{
    class Product
    {
        public Product(double price, double quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] productInfo = input.Split();
                string product = productInfo[0];
                double price = double.Parse(productInfo[1]);
                double quantity = double.Parse(productInfo[2]);
                if (!products.ContainsKey(product))
                {
                    products[product] = new Product(price, quantity);
                }
                else
                {
                    products[product].Price = price;
                    products[product].Quantity += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:f2}");
            }
        }
    }
}
