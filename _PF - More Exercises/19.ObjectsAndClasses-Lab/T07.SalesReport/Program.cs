using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.SalesReport
{
    class Sale
    {
        public Sale(string town, string product, double price, double quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> sales = new List<Sale>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                sales.Add(ReadSale(input));
            }

            List<string> towns = new List<string>();
            foreach (var sale in sales)
            {
                if (!towns.Contains(sale.Town))
                {
                    towns.Add(sale.Town);
                }
            }
            towns.Sort();
            for (int i = 0; i < towns.Count; i++)
            {
                double total = 0;
                for (int j = 0; j < sales.Count; j++)
                {
                    if (sales[j].Town == towns[i])
                    {
                        total += sales[j].Quantity * sales[j].Price;
                    }
                }

                Console.WriteLine($"{towns[i]} -> {total:f2}");
            }

        }

        static Sale ReadSale(string[] input)
        {

            string town = input[0];
            string product = input[1];
            double price = double.Parse(input[2]);
            double quantity = double.Parse(input[3]);
            Sale sale = new Sale(town, product, price, quantity);
            return sale;
        }
    }
}
