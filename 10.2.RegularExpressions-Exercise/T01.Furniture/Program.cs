using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<item>[A-Za-z]+)<<(?<price>(\d+\.)?\d+)!(?<quantity>\d+)");
            List<string> items = new List<string>();
            decimal total = 0;

            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    items.Add(match.Groups["item"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    total += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
