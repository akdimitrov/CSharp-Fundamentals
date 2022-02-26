using System;
using System.Collections.Generic;
using System.Linq;

namespace T11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "exchange": Exchange(array, int.Parse(command[1])); break;
                    case "max": PrintMaxElementIndex(array, command[1]); break;
                    case "min": PrintMinElementIndex(array, command[1]); break;
                    case "first": PrintFisrstNElements(array, int.Parse(command[1]), command[2]); break;
                    case "last": PrintLastNElements(array, int.Parse(command[1]), command[2]); break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", array)}]");
        }

        static void PrintLastNElements(int[] array, int count, string evenOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> elements = new List<int>();
                if (evenOdd == "even")
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 0)
                        {
                            elements.Add(array[i]);
                            if (elements.Count == count) break;
                        }
                    }
                }
                else
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 != 0)
                        {
                            elements.Add(array[i]);
                            if (elements.Count == count) break;
                        }
                    }
                }
                elements.Reverse();
                Console.WriteLine($"[{String.Join(", ", elements)}]");
            }
        }

        static void PrintFisrstNElements(int[] array, int count, string evenOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> elements = new List<int>();
                if (evenOdd == "even")
                {
                    foreach (var num in array)
                    {
                        if (num % 2 == 0)
                        {
                            elements.Add(num);
                            if (elements.Count == count) break;
                        }
                    }
                }
                else
                {
                    foreach (var num in array)
                    {
                        if (num % 2 != 0)
                        {
                            elements.Add(num);
                            if (elements.Count == count) break;
                        }
                    }
                }
                Console.WriteLine($"[{String.Join(", ", elements)}]");
            }
        }

        static void PrintMinElementIndex(int[] array, string v)
        {
            bool isFound = false;
            int minIndex = 0;
            int smallest = int.MaxValue;
            if (v == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= smallest)
                    {
                        smallest = array[i];
                        minIndex = i;
                        isFound = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] <= smallest)
                    {
                        smallest = array[i];
                        minIndex = i;
                        isFound = true;
                    }
                }
            }

            Console.WriteLine(isFound ? minIndex.ToString() : "No matches");
        }

        static void PrintMaxElementIndex(int[] array, string v)
        {
            bool isFound = false;
            int maxIndex = 0;
            int biggestNum = int.MinValue;
            if (v == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= biggestNum)
                    {
                        biggestNum = array[i];
                        maxIndex = i;
                        isFound = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] >= biggestNum)
                    {
                        biggestNum = array[i];
                        maxIndex = i;
                        isFound = true;
                    }
                }
            }

            Console.WriteLine(isFound ? maxIndex.ToString() : "No matches");
        }

        static void Exchange(int[] array, int n)
        {
            if (n < 0 || n >= array.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    int temp = array[0];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[^1] = temp;
                }
            }
        }
    }
}
