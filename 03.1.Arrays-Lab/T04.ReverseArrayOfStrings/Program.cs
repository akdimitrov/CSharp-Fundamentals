using System;
using System.Linq;

namespace T04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine().Split().ToArray().Reverse()));
        }
    }
}
