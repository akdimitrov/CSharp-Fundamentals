using System;

namespace T11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double currentPrice = days * capsules * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
                total += currentPrice;
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
