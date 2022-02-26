using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            int moves = 0;
            while (input != "end")
            {
                int[] array = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int index1 = array[0];
                int index2 = array[1];
                moves++;
                if (index1 < 0 || index1 >= board.Count || index2 < 0 || index2 >= board.Count)
                {
                    board.Insert(board.Count / 2, $"-{moves}a");
                    board.Insert(board.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (board[index1] == board[index2])
                {
                    string element = board[index1];
                    board.RemoveAll(x => x == element);
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (board.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "end")
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", board));
            }
        }
    }
}
