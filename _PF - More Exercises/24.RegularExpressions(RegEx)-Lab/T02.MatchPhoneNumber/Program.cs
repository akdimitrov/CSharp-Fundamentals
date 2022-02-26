using System;
using System.Text.RegularExpressions;

namespace T02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection validPhoneNumbers = Regex.Matches(Console.ReadLine(), @"(?<!\S)\+359([ \-])2\1\d{3}\1\d{4}\b");
            Console.WriteLine(String.Join(", ", validPhoneNumbers));
        }
    }
}
