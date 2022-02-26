using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "print")
            {
                string action = command[0];
                if (action == "add")
                {
                    list.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (action == "addMany")
                {
                    for (int i = command.Length - 1; i >= 2 ; i--)
                    {
                        list.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (action == "contains")
                {
                    if (list.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine(list.IndexOf(int.Parse(command[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (action == "remove")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (action == "shift")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        int temp = list[0];
                        for (int j = 0; j < list.Count - 1; j++)
                        {
                            list[j] = list[j + 1];
                        }
                        list[list.Count - 1] = temp;
                    }
                }
                else if (action == "sumPairs")
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        list[i] += list[i + 1];
                        list.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }
}
