using System;
using System.Linq;

namespace T07.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptions = 0;
            while (exceptions < 3)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                int index;
                bool success1 = int.TryParse(input[1], out index);
                if (!success1)
                {
                    Console.WriteLine($"The variable is not in the correct format!");
                    exceptions++;
                    continue;
                }

                if (command == "Replace")
                {
                    int element;
                    bool success2 = int.TryParse(input[2], out element);

                    if (!success2)
                    {
                        Console.WriteLine($"The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }

                    if (index >= 0 && index <= array.Length - 1)
                    {
                        array[index] = element;
                    }
                    else
                    {
                        exceptions++;
                        Console.WriteLine("The index does not exist!");
                    }

                }
                else if (command == "Print")
                {
                    int index2;
                    bool success2 = int.TryParse(input[2], out index2);

                    if (!success2)
                    {
                        Console.WriteLine($"The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }

                    if (index >= 0 && index <= array.Length - 1 &&
                        index2 >= index && index2 <= array.Length - 1)
                    {
                        for (int i = index; i <= index2; i++)
                        {
                            if (i > index)
                            {
                                Console.Write(", ");
                            }
                            Console.Write(array[i]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        exceptions++;
                        Console.WriteLine("The index does not exist!");
                    }
                }
                else if (command == "Show")
                {
                    if (index >= 0 && index <= array.Length - 1)
                    {
                        Console.WriteLine(array[index]);
                    }
                    else
                    {
                        exceptions++;
                        Console.WriteLine("The index does not exist!");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
