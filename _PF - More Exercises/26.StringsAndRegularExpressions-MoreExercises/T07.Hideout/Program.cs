using System;
using System.Text.RegularExpressions;

namespace T07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            while (true)
            {
                string[] array = Console.ReadLine().Split();
                string symbol = Regex.Escape(array[0]);
                int lenght = int.Parse(array[1]);
                Match match = Regex.Match(map, $@"{symbol}{{{lenght},}}");
                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
            }
        }
    }
}
