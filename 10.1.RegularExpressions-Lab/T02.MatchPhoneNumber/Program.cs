using System;
using System.Text.RegularExpressions;

namespace T02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=^|\s)\+359([ -])2\1\d{3}\1\d{4}\b");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
