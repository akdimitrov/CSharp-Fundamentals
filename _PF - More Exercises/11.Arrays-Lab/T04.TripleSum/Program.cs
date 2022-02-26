using System;
using System.Linq;

namespace T04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isNotFound = true;

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (array[a] + array[b] == array[c])
                        {
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[c]}");
                            isNotFound = false;
                            break;
                        }
                    }
                }
            }

            if (isNotFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
