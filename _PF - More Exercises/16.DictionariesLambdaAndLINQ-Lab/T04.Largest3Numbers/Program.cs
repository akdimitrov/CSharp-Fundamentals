using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
