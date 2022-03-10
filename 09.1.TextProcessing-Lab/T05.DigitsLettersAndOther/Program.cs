using System;
using System.Linq;

namespace T05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Where(x => char.IsDigit(x)).ToArray());
            Console.WriteLine(input.Where(x => char.IsLetter(x)).ToArray());
            Console.WriteLine(input.Where(x => !char.IsLetterOrDigit(x)).ToArray());
        }
    }
}
