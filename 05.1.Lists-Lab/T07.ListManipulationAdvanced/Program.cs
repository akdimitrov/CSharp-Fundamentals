using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmd = input.Split();
                string command = cmd[0];

                if (command == "Add")
                {
                    numbers.Add(int.Parse(cmd[1]));
                    isChanged = true;
                }
                else if (command == "Remove")
                {
                    if (numbers.Remove(int.Parse(cmd[1])))
                    {
                        isChanged = true;
                    }
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(cmd[1]));
                    isChanged = true;
                }
                else if (command == "Insert")
                {
                    numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                    isChanged = true;
                }
                else if (command == "Contains")
                {
                    Console.WriteLine(numbers.Contains(int.Parse(cmd[1])) ? "Yes" : "No such number");
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string operation = cmd[1];
                    int number = int.Parse(cmd[2]);
                    switch (operation)
                    {
                        case "<": Console.WriteLine(String.Join(" ", numbers.Where(x => x < number))); break;
                        case ">": Console.WriteLine(String.Join(" ", numbers.Where(x => x > number))); break;
                        case ">=": Console.WriteLine(String.Join(" ", numbers.Where(x => x >= number))); break;
                        case "<=": Console.WriteLine(String.Join(" ", numbers.Where(x => x <= number))); break;
                    }
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
