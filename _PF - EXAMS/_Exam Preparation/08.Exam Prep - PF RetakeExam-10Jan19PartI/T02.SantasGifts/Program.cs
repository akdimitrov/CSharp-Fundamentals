using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.SantasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int currentIndex = 0;
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                int num = int.Parse(cmd[1]);
                if (command == "Forward")
                {
                    if (currentIndex + num < houses.Count)
                    {
                        currentIndex += num;
                        houses.RemoveAt(currentIndex);
                    }
                }
                else if (command == "Back")
                {
                    if (currentIndex - num >= 0)
                    {
                        currentIndex -= num;
                        houses.RemoveAt(currentIndex);
                    }
                }
                else if (command == "Gift")
                {
                    if (num >= 0 && num <= houses.Count)
                    {
                        houses.Insert(num, int.Parse(cmd[2]));
                        currentIndex = num;
                    }
                }
                else if (command == "Swap")
                {
                    int secondHouse = int.Parse(cmd[2]);
                    if (houses.Contains(num) && houses.Contains(secondHouse))
                    {
                        int firstHouseIndex = houses.IndexOf(num);
                        int secondHouseIndex = houses.IndexOf(secondHouse);
                        houses[firstHouseIndex] = secondHouse;
                        houses[secondHouseIndex] = num;
                    }
                }
            }

            Console.WriteLine($"Position: {currentIndex}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
