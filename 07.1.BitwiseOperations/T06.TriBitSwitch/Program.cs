﻿using System;

namespace T06.TriBitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = 7 << position;
            int result = number ^ mask;
            Console.WriteLine(result);
        }
    }
}
