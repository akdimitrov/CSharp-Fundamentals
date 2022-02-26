using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "Finish")
            {
                string[] cmd = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                int value = int.Parse(cmd[1]);

                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (command == "Replace" && numbers.Contains(value))
                {
                    numbers[numbers.IndexOf(value)] = int.Parse(cmd[2]);
                }
                else if (command == "Collapse")
                {
                    numbers = numbers.Where(x => x >= value).ToList();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
