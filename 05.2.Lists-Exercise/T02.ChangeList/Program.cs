using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmd = input.Split();
                string command = cmd[0];
                int element = int.Parse(cmd[1]);
                if (command == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmd[2]);
                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
