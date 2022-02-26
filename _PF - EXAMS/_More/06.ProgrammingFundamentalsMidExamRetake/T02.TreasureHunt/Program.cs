using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "Yohoho!")
            {
                if (commands[0] == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (!chest.Contains(commands[i]))
                        {
                            chest.Insert(0, commands[i]);
                        }
                    }
                }
                else if (commands[0] == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < chest.Count)
                    {
                        string temp = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(temp);
                    }
                }
                else if (commands[0] == "Steal")
                {
                    int count = int.Parse(commands[1]);
                    count = Math.Min(count, chest.Count);
                    int startingIndex = chest.Count - count;
                    List<string> stolenItems = new List<string>();
                    while (count > 0)
                    {
                        stolenItems.Add(chest[startingIndex]);
                        chest.RemoveAt(startingIndex);
                        count--;
                    }

                    Console.WriteLine(string.Join(", ", stolenItems));
                }

                commands = Console.ReadLine().Split();
            }

            if (chest.Count > 0)
            {
                double average = 0;
                foreach (var item in chest)
                {
                    average += item.Length;
                }
                average /= chest.Count;
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
