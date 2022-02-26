using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] detonation = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = detonation[0];
            int power = detonation[1];
            while (list.Contains(bomb))
            {
                int index = list.IndexOf(bomb);
                int start = Math.Max(index - power, 0);
                int end = Math.Min(index + power, list.Count - 1);
                list.RemoveRange(start, end - start + 1);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
