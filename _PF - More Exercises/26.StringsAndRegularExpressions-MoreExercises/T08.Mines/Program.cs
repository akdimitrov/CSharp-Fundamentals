using System;
using System.Text.RegularExpressions;

namespace T08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex minePattern = new Regex(@"<(..)>");
            MatchCollection mines = minePattern.Matches(input);
            foreach (Match mine in mines)
            {
                int power = Math.Abs(mine.Groups[1].Value[0] - mine.Groups[1].Value[1]);
                int start = Math.Max(0, mine.Index - power);
                int end = Math.Min(mine.Index + 4 + power, input.Length);
                string mineDestruction = input.Substring(start, end - start);
                input = input.Replace(mineDestruction, new string('_', mineDestruction.Length));
            }
            Console.WriteLine(input);
        }
    }
}
