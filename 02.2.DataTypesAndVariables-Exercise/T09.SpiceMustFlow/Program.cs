using System;

namespace T09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalYield = 0;
            while (startingYield >= 100)
            {
                days++;
                totalYield += startingYield - 26;
                startingYield -= 10;
            }
            totalYield -= 26;
            Console.WriteLine(days);
            Console.WriteLine(totalYield > 0 ? totalYield : 0);
        }
    }
}
