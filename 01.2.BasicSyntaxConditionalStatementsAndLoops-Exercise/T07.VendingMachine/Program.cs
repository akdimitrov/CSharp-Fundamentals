using System;

namespace T07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                double coin = double.Parse(input);
                bool isValid = coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2;
                if (isValid) total += coin;
                else Console.WriteLine($"Cannot accept {coin}");
                input = Console.ReadLine();
            }

            string item = Console.ReadLine();
            while (item != "End")
            {
                double price = 0;
                switch (item)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default:
                        Console.WriteLine("Invalid product");
                        item = Console.ReadLine();
                        continue;
                }
                if (price <= total)
                {
                    Console.WriteLine($"Purchased {item.ToLower()}");
                    total -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                item = Console.ReadLine();
            }

            Console.WriteLine($"Change: {total:f2}");
        }
    }
}
