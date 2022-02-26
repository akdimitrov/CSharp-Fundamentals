using System;
using System.Linq;

namespace T02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotTargets = 0;
            string input = Console.ReadLine();
            while (input != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < array.Length)
                {
                    if (array[index] != -1)
                    {
                        shotTargets++;
                        int temp = array[index];
                        array[index] = -1;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == -1)
                            {
                                continue;
                            }
                            else if (array[i] <= temp)
                            {
                                array[i] += temp;
                            }
                            else
                            {
                                array[i] -= temp;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", array)}");
        }
    }
}
