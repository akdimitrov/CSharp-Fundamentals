using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine().ToUpper(), @"(.+?)(\d{1,2})");
            StringBuilder message = new StringBuilder();
            foreach (Match match in matches)
            {
                string substring = match.Groups[1].Value;
                int count = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    message.Append(substring);
                }
            }

            Console.WriteLine($"Unique symbols used: {message.ToString().Distinct().Count()}");
            Console.WriteLine(message);
        }
    }
}
