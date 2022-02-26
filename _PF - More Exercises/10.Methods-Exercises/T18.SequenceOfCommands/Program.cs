using System;
using System.Collections.Generic;
using System.Linq;

namespace T18.SequenceOfCommands
{
    class Program
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            List<long> list = Console.ReadLine().Split().Select(long.Parse).ToList();
            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] line = command.Split();
                PerformAction(list, line);
                Console.WriteLine(string.Join(" ", list));
                command = Console.ReadLine();
            }
        }

        static void PerformAction(List<long> list,
            string[] line)
        {
            string action = line[0];
            int index = 0;
            int value = 0;
            switch (action)
            {
                case "multiply":
                    index = int.Parse(line[1]) - 1;
                    value = int.Parse(line[2]);
                    list[index] *= value;
                    break;
                case "add":
                    index = int.Parse(line[1]) - 1;
                    value = int.Parse(line[2]);
                    list[index] += value;
                    break;
                case "subtract":
                    index = int.Parse(line[1]) - 1;
                    value = int.Parse(line[2]);
                    list[index] -= value;
                    break;
                case "lshift":
                    ListShiftLeft(list);
                    break;
                case "rshift":
                    ListShiftRight(list);
                    break;
            }
        }

        private static void ListShiftRight(List<long> list)
        {
            long temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, temp);
        }

        private static void ListShiftLeft(List<long> list)
        {
            long temp = list[0];
            list.RemoveAt(0);
            list.Add(temp);
        }
    }
}
