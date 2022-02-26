using System;

namespace T06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
