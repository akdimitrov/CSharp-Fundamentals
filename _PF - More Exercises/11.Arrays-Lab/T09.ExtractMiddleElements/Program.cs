using System;
using System.Linq;

namespace T09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = array.Length;
            if (length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (length % 2 == 0)
            {
                int element = length / 2 - 1;
                Console.WriteLine($"{{ {array[element]}, {array[element + 1]} }}");
            }
            else
            {
                int element = length / 2 - 1;
                Console.WriteLine($"{{ {array[element]}, {array[element + 1]}, {array[element + 2]} }}");
            }
        }
    }
}
