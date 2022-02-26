using System;
using System.Collections.Generic;

namespace T03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string guest = input.Split()[0];
                if (!input.Contains("not"))
                {
                    if (!guests.Contains(guest))
                    {
                        guests.Add(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(guest))
                    {
                        guests.Remove(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join("\n", guests));
        }
    }
}
