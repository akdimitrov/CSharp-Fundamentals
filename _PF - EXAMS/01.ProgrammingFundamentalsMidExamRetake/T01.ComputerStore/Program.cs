using System;

namespace T01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal orderPice = 0;
            string input = Console.ReadLine();
            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    orderPice += price;
                }

                input = Console.ReadLine();
            }

            if (orderPice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                decimal taxes = orderPice * 0.2m;
                decimal totalPrice = orderPice + taxes;
                if (input == "special")
                {
                    totalPrice *= 0.9m;
                }
                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {orderPice:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {totalPrice:f2}$");
            }
        }
    }
}
