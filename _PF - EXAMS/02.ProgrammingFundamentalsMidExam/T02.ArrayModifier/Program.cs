using System;
using System.Linq;

namespace T02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "swap")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    var temp = array[index1];
                    array[index1] = array[index2];
                    array[index2] = temp;
                }
                else if (cmd[0] == "multiply")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    array[index1] *= array[index2];
                }
                else if (cmd[0] == "decrease")
                {
                    array = array.Select(x => x - 1).ToArray();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
