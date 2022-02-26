using System;
using System.Linq;

namespace T03.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int maxHelath = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "Retire")
            {
                if (commands[0] == "Fire")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < warShip.Length)
                    {
                        warShip[index] -= int.Parse(commands[2]);
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (commands[0] == "Defend")
                {
                    int startI = int.Parse(commands[1]);
                    int endI = int.Parse(commands[2]);
                    if (startI >= 0 && startI < pirateShip.Length &&
                        endI >= 0 && endI < pirateShip.Length)
                    {
                        for (int i = startI; i <= endI; i++)
                        {
                            pirateShip[i] -= int.Parse(commands[3]);
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (commands[0] == "Repair")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < pirateShip.Length)
                    {
                        pirateShip[index] += int.Parse(commands[2]);
                        if (pirateShip[index] > maxHelath)
                        {
                            pirateShip[index] = maxHelath;
                        }
                    }

                }
                else if (commands[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        if (pirateShip[i] < maxHelath / 5)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
