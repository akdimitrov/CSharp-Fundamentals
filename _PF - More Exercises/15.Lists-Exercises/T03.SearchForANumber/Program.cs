using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list.RemoveRange(array[0], list.Count - array[0]);
            list.RemoveRange(0, array[1]);
            if (list.Contains(array[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
