using System;
using System.Linq;

namespace T05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            if (array1.Length != array2.Length)
            {

                Console.WriteLine(string.Join("", array1.Length < array2.Length ? array1 : array2));
                Console.WriteLine(string.Join("", array1.Length < array2.Length ? array2 : array1));
            }
            else
            {
                char[] minArray = array1;
                char[] maxArray = array2;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < array2[i])
                    {
                        minArray = array1;
                        maxArray = array2;
                        break;
                    }
                    else if (array1[i] > array2[i])
                    {
                        minArray = array2;
                        maxArray = array1;
                        break;
                    }
                }

                Console.WriteLine(string.Join("", minArray));
                Console.WriteLine(string.Join("", maxArray));
            }
        }
    }
}
