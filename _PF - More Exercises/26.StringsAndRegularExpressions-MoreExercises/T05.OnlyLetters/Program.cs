using System;
using System.Text.RegularExpressions;

namespace T05.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\d+)([A-Za-z])");
            input = regex.Replace(input, "$2$2");
            Console.WriteLine(input);
        }
    }
}
