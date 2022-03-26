using System;

namespace T01.CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());
            double price = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 != 0)
                {
                    price += flourPrice;
                }
                price += eggPrice * 10;
            }

            price += Math.Ceiling(students * 1.2) * apronPrice;

            if (price <= budget)
            {
                Console.WriteLine($"Items purchased for {price:f2}$.");
            }
            else
            {
                Console.WriteLine($"{price - budget:f2}$ more needed.");
            }
        }
    }
}
