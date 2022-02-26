using System;
using System.Linq;

namespace T07.InventoryMatcher
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
                int index = Array.IndexOf(products, input);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");
                input = Console.ReadLine();
            }
        }
    }
}
