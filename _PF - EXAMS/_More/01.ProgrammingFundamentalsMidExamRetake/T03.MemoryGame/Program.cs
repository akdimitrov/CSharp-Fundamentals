using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split();
            int moves = 0;
            while (input[0] != "end")
            {
                moves++;
                int index1 = int.Parse(input[0]);
                int index2 = int.Parse(input[1]);
                bool isInvalid = index1 == index2 || index1 < 0 || index1 > list.Count - 1 || index2 < 0 || index2 > list.Count - 1;
                if (isInvalid)
                {
                    list.Insert(list.Count / 2, $"-{moves}a");
                    list.Insert(list.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (list[index1] == list[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");
                    list.RemoveAt(Math.Max(index1, index2));
                    list.RemoveAt(Math.Min(index1, index2));
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                input = Console.ReadLine().Split();
            }

            if (list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
