using System;
using System.Linq;

namespace T05.WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { '.', ',', '!', '?', ':' };
            string[] input = Console.In.ReadToEnd().Split(symbols);
            Console.WriteLine(String.Join("", input));
        }
    }
}
