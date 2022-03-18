using System;
using System.Text.RegularExpressions;

namespace T06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emailValidationPattern = new Regex(@"(?<= )([a-z\d]+[.\-_]?)*[a-z\d]+@([a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+");
            MatchCollection validEmails = emailValidationPattern.Matches(Console.ReadLine());
            foreach (Match email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
