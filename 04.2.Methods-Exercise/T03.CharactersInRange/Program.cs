using System;
using System.Collections.Generic;

namespace T03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            PrintCharactersInRange(first, last);
        }

        private static void PrintCharactersInRange(char first, char last)
        {
            if (last < first)
            {
                int temp = first;
                first = last;
                last = (char)temp;
            }
            List<char> characters = new List<char>();
            for (int i = first + 1; i < last; i++)
            {
                characters.Add((char)i);
            }
            Console.WriteLine(String.Join(" ", characters));
        }
    }
}
