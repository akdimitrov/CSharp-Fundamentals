using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace T01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split().OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", times));
        }
    }
}
