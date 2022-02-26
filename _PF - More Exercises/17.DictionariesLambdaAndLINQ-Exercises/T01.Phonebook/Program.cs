using System;
using System.Collections.Generic;

namespace T01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input.Split();
                string command = info[0];
                string name = info[1];

                if (command == "A")
                {
                    phonebook[name] = info[2];
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
