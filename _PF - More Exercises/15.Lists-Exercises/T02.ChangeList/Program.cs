using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "Even" && input != "Odd")
            {
                string[] command = input.Split();
                int num = int.Parse(command[1]);
                if (command[0] == "Delete")
                {
                    list.RemoveAll(el => el == num);
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), num);
                }

                input = Console.ReadLine();
            }

            if (input == "Even")
            {
                foreach (var item in list)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            else
            {
                foreach (var item in list)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
