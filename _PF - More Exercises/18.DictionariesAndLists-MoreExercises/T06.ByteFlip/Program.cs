using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine().Split().Where(x => x.Length == 2).ToList();
            symbols = symbols.Select(x => new string(x.ToCharArray().Reverse().ToArray())).Reverse().ToList();
            Console.WriteLine(String.Join("", symbols.Select(x => (char)int.Parse(x, System.Globalization.NumberStyles.HexNumber))));
        }
    }
}
