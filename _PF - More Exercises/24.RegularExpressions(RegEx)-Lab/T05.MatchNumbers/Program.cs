using System;
using System.Text.RegularExpressions;

namespace T05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"(?<!\S)\-?\d+(\.\d+)?(?!\S)");
            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
