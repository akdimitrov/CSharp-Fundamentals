using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split();
                string command = cmd[0];
                int index = int.Parse(cmd[1]);
                int value = int.Parse(cmd[2]);
                bool indexIsValid = index >= 0 && index < list.Count;
                if (command == "Shoot" && indexIsValid)
                {
                    list[index] -= value;
                    if (list[index] <= 0)
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (command == "Add")
                {
                    if (indexIsValid)
                    {
                        list.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike" && indexIsValid)
                {
                    if (index - value >= 0 && index + value < list.Count)
                    {
                        list.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
            }

            Console.WriteLine(String.Join("|", list));
        }
    }
}
