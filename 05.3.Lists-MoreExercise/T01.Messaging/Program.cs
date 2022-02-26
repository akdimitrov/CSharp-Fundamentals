using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => x.ToCharArray().Sum(x => int.Parse(x.ToString()))).ToList();
            string text = Console.ReadLine();
            foreach (var number in numbers)
            {
                int index = number % text.Length;
                Console.Write(text[index]);
                text = text.Remove(index, 1);
            }
            Console.WriteLine();
        }
    }
}
