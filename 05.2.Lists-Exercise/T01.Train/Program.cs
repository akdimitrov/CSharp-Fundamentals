using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmd = input.Split();
                if (cmd.Length == 2 && cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    int passengers = int.Parse(cmd[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
