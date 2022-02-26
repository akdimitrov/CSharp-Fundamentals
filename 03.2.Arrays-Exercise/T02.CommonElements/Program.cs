using System;
using System.Linq;

namespace T02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            Console.WriteLine(String.Join(" ", array2.Where(x => array1.Contains(x))));
        }
    }
}
