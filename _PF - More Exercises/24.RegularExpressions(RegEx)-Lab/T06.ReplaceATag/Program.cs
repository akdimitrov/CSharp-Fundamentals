using System;
using System.Text;
using System.Text.RegularExpressions;

namespace T06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<a(.+?)>(.+?)<\/a>");
            string replace = @"[URL$1]$2[/URL]";
            StringBuilder output = new StringBuilder();
            string input = Console.ReadLine();
            while (input != "end")
            {
                input = regex.Replace(input, replace);
                output.AppendLine(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(output);
        }
    }
}
