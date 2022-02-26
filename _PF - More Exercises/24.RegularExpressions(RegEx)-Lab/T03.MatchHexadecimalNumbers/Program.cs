using System;
using System.Text.RegularExpressions;

namespace T03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b(?:0x)?[\dA-F]+\b");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
