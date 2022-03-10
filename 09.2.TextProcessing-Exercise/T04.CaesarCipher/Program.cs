using System;
using System.Linq;

namespace T04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encrypted = new string(text.Select(x => (char)(x + 3)).ToArray());
            Console.WriteLine(encrypted);
        }
    }
}
