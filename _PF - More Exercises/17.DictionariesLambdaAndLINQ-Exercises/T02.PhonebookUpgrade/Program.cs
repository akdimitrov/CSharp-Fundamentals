using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input.Split();
                string command = info[0];
                if (command == "A")
                {
                    phonebook[info[1]] = info[2];
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(info[1]))
                    {
                        Console.WriteLine($"{info[1]} -> {phonebook[info[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {info[1]} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
