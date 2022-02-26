using System;
using System.Linq;

namespace T03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split();
                if (input == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (input == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Replace" && int.Parse(command[1]) >= 0 && int.Parse(command[1]) < array.Length)
                {
                    array[int.Parse(command[1])] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
