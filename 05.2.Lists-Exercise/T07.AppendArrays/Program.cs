using System;
using System.Linq;

namespace T07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|").Reverse().ToArray();
            string[] result = string.Join(" ", array).Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
