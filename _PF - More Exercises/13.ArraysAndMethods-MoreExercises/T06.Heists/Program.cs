using System;
using System.Linq;

namespace T06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = 0;
            string input = Console.ReadLine();

            while (input != "Jail Time")
            {
                string[] lootHeist = input.Split();
                string loot = lootHeist[0];
                int heist = int.Parse(lootHeist[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        sum += price[0];
                    }
                    else if (loot[i] == '$')
                    {
                        sum += price[1];
                    }
                }

                sum -= heist;
                input = Console.ReadLine();
            }

            if (sum >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {sum}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(sum)}.");
            }
        }
    }
}
