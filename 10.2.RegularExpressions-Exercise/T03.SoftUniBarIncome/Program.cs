using System;
using System.Text.RegularExpressions;

namespace T03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<quantity>\d+)\|.*?(?<price>(\d+\.)?\d+)\$");
            decimal total = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value) * quantity;
                    total += price;
                    Console.WriteLine($"{name}: {product} - {price:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
