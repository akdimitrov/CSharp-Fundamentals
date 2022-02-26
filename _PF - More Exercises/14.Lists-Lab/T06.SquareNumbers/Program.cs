using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                if (Math.Sqrt(num) != (int)Math.Sqrt(num))
                {
                    list.RemoveAt(i--);
                }
            }

            list.Sort();
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
