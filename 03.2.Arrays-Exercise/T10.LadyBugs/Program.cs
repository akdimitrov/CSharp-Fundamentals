using System;
using System.Linq;

namespace T10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ladyBugs = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (ladyBugsIndexes.Contains(i))
                {
                    ladyBugs[i] = 1;
                }
            }

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] array = input.Split();
                int ladyBugIndex = int.Parse(array[0]);
                string direction = array[1];
                int flyLength = int.Parse(array[2]);

                if (ladyBugIndex >= 0 && ladyBugIndex < n && ladyBugs[ladyBugIndex] == 1 && flyLength != 0)
                {
                    while (true)
                    {
                        int landingIndex = ladyBugIndex - flyLength;
                        if (direction == "right")
                        {
                            landingIndex = ladyBugIndex + flyLength;

                        }

                        if (landingIndex < 0 || landingIndex >= n)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                            break;
                        }

                        if (ladyBugs[landingIndex] == 1)
                        {
                            flyLength += flyLength;
                        }
                        else
                        {
                            ladyBugs[landingIndex] = 1;
                            ladyBugs[ladyBugIndex] = 0;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", ladyBugs));
        }
    }
}
