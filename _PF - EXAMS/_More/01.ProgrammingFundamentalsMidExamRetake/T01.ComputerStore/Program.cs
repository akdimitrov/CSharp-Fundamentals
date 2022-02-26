using System;

namespace T01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += price;
                }

                input = Console.ReadLine();
            }

            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double taxes = total * 0.2;
                double finalSum = total + taxes;
                if (input == "special")
                {
                    finalSum *= 0.9;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalSum:f2}$");
            }
        }
    }
}
