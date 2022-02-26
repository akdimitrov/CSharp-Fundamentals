using System;

namespace T10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(char.IsUpper(ch) ? "upper-case" : "lower-case");
        }
    }
}
