using System;
using System.Linq;

namespace T08.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "done")
            {
                string[] array = input.Split();
                string product = array[0];
                long quantity = long.Parse(array[1]);
                int index = Array.IndexOf(products, product);

                if (index >= quantities.Length || quantity > quantities[index])
                {
                    Console.WriteLine($"We do not have enough {product}");
                }
                else
                {
                    Console.WriteLine($"{product} x {quantity} costs {prices[index] * quantity:f2}");
                    quantities[index] -= quantity;
                }

                input = Console.ReadLine();
            }
        }
    }
}
