using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split();
                string command = cmd[0];
                switch (command)
                {
                    case "Add": numbers.Add(int.Parse(cmd[1])); break;
                    case "Insert":
                        if (int.Parse(cmd[2]) >= 0 && int.Parse(cmd[2]) < numbers.Count)
                        {
                            numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(cmd[1]) >= 0 && int.Parse(cmd[1]) < numbers.Count)
                        {
                            numbers.RemoveAt(int.Parse(cmd[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift": numbers = ShiftList(numbers, cmd[1], int.Parse(cmd[2])); break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> ShiftList(List<int> numbers, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int temp = numbers[0];
                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    numbers[^1] = temp;
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    int temp = numbers[^1];
                    for (int j = numbers.Count - 1; j > 0; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }
                    numbers[0] = temp;
                }
            }
            return numbers;
        }
    }
}
