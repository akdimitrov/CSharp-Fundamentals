using System;

namespace T03.PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int postion = int.Parse(Console.ReadLine());
            int bitAtPosition = (number >> postion) & 1;
            Console.WriteLine(bitAtPosition);
        }
    }
}
