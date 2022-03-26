using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T03.SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> children = new List<string>();
            Regex regex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*?!(?<behaviour>[GN])!");
            int key = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string message = string.Join("", input.ToCharArray().Select(x => (char)(x - key)));
                Match match = regex.Match(message);
                if (match.Success && match.Groups["behaviour"].Value == "G")
                {
                    children.Add(match.Groups["name"].Value);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, children));
        }
    }
}
