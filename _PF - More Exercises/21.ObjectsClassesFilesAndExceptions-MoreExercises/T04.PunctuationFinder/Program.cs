using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { '.', ',', '!', '?', ':' };
            char[] input = Console.In.ReadToEnd().ToCharArray();
            char[] result = input.Where(x => symbols.Contains(x)).ToArray();
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
