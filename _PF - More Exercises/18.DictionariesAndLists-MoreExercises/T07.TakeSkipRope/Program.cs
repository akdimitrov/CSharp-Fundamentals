using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Where(x => Char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();
            List<char> symbols = input.Where(x => !Char.IsDigit(x)).ToList();
            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    skipList.Add(numbers[i]);
                }
                else
                {
                    takeList.Add(numbers[i]);
                }
            }
            List<char> message = new List<char>();
            for (int i = 0; i < skipList.Count; i++)
            {
                message.AddRange(symbols.Take(takeList[i]));
                symbols.RemoveRange(0, Math.Min(symbols.Count, takeList[i] + skipList[i]));
            }

            Console.WriteLine(String.Join("", message));
        }
    }
}
