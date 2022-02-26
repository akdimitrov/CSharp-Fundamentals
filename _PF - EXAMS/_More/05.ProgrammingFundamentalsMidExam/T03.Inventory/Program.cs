using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(" - ");
            while (command[0] != "Craft!")
            {
                string item = command[1];
                if (command[0] == "Collect")
                {
                    if (!list.Contains(item))
                    {
                        list.Add(item);
                    }
                }
                else if (command[0] == "Drop")
                {
                    list.Remove(item);
                }
                else if (command[0] == "Combine Items")
                {
                    string[] items = item.Split(":");
                    if (list.Contains(items[0]))
                    {
                        list.Insert(list.IndexOf(items[0]) + 1, items[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
