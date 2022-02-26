using System;
using System.Text.RegularExpressions;

namespace T01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<= )[a-z\d]+([\.\-_][a-z\d]+)*@[a-z\d]+(\-[a-z\d]+)*(\.[a-z\d]+(\-[a-z\d]+)*)+\b");
            MatchCollection validEmails = regex.Matches(Console.ReadLine());
            Console.WriteLine(String.Join("\n", validEmails));
        }
    }
}
