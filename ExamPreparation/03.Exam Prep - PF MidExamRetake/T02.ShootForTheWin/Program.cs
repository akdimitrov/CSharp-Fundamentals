using System;
using System.Linq;

namespace T02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < array.Length && array[index] != -1)
                {
                    int value = array[index];
                    array[index] = -1;
                    array = array.Select(x => x == -1 ? x = -1 : x > value ? x - value : x + value).ToArray();
                }
            }

            Console.WriteLine($"Shot targets: {array.Count(x => x == -1)} -> {String.Join(" ", array)}");
        }
    }
}
