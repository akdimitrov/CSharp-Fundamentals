using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int number = int.Parse(commands[1]);
                if (command == "Add")
                {
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), number);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
