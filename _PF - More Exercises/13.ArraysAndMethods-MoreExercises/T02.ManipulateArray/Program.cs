using System;
using System.Linq;

namespace T02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else
                {
                    string[] action = command.Split();
                    array[int.Parse(action[1])] = action[2];
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
