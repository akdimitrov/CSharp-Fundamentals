using System;
using System.Linq;

namespace T02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = input.Where(x => x > first && x < last).ToArray().Sum(x => x);
            Console.WriteLine(sum);
        }
    }
}
