using System;
using System.Text;
using System.Text.RegularExpressions;

namespace T08.UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"<p>(.+?)<\/p>");
            Regex replacePattern = new Regex(@"[^a-z\d]+");
            MatchCollection matches = pattern.Matches(Console.ReadLine());
            StringBuilder decrypted = new StringBuilder();
            foreach (Match match in matches)
            {
                string text = replacePattern.Replace(match.Groups[1].Value, " ");
                foreach (var item in text)
                {
                    decrypted.Append(char.IsLetter(item) ? item - 13 < 'a' ? (char)(item + 13) : (char)(item - 13) : item);
                }
            }
            Console.WriteLine(decrypted);
        }
    }
}
