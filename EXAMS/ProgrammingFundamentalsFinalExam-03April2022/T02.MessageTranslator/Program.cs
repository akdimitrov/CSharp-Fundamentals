using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"!(?<command>[A-Z][a-z]{2,})!:\[(?<text>[A-Za-z]{8,})\]");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match match = regex.Match(message);
                if (!match.Success)
                {
                    Console.WriteLine($"The message is invalid");
                    continue;
                }

                int[] numbers = match.Groups["text"].Value.ToCharArray().Select(x => (int)x).ToArray();
                Console.WriteLine($"{match.Groups["command"].Value}: {string.Join(" ", numbers)}");
            }
        }
    }
}
