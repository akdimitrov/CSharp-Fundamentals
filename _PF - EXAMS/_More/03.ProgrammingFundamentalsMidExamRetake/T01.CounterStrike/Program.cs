using System;

namespace T01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            string input = Console.ReadLine();
            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    break;
                }
                energy -= distance;
                wins++;
                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                input = Console.ReadLine();
            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
