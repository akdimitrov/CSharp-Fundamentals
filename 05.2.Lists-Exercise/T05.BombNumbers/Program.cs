using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> field = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = array[0];
            int power = array[1];
            while (field.Contains(bomb))
            {
                int startIndex = Math.Max(field.IndexOf(bomb) - power, 0);
                int endIndex = Math.Min(field.IndexOf(bomb) + power, field.Count - 1);
                field.RemoveRange(startIndex, endIndex - startIndex + 1);
            }

            Console.WriteLine(field.Sum());
        }
    }
}
