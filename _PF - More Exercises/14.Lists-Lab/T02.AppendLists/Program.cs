using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<int> list = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                list.AddRange(array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}