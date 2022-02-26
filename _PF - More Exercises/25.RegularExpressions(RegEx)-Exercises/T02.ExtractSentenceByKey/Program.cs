using System;
using System.Text.RegularExpressions;

namespace T02.ExtractSentenceByKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            MatchCollection matches = Regex.Matches(Console.ReadLine(), $@"\b[^.!?]*\b{key}\b[^.!?]*");
            Console.WriteLine(String.Join("\n", matches));
        }
    }
}
