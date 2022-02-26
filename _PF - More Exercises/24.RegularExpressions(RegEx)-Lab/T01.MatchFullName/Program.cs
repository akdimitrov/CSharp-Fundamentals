using System;
using System.Text.RegularExpressions;

namespace T01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection names = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            Console.WriteLine(String.Join(" ", names));
        }
    }
}
