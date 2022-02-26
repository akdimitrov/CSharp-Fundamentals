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
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                string action = command[0];
                int index = int.Parse(command[1]);
                int n = int.Parse(command[2]);
                bool isIndexValid = index >= 0 && index < list.Count;
                if (action == "Shoot")
                {
                    if (isIndexValid)
                    {
                        list[index] -= n;
                        if (list[index] <= 0)
                        {
                            list.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    if (isIndexValid)
                    {
                        list.Insert(index, n);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    if (isIndexValid)
                    {
                        if (index - n >= 0 && index + n < list.Count)
                        {
                            int start = index - n;
                            int end = index + n;
                            list.RemoveRange(start, end - start + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join("|", list));
        }
    }
}
