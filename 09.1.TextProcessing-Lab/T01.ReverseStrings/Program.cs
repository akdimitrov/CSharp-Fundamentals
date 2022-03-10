using System;
using System.Linq;

namespace T01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string reversed = new string(input.Reverse().ToArray());
                Console.WriteLine($"{input} = {reversed}");
                input = Console.ReadLine();
            }
        }
    }
}
