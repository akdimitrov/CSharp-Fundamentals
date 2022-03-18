using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T04.SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                string message = string.Join("", input.Select(x => (char)(x - key)));
                Match kid = Regex.Match(message, @"@([A-Za-z]+)[^@\-!:>]*!(G)!");
                if (kid.Success)
                {
                    Console.WriteLine(kid.Groups[1].Value);
                }
                input = Console.ReadLine();
            }
        }
    }
}
