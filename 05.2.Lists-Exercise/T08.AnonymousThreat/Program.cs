using System;
using System.Collections.Generic;
using System.Linq;

namespace T08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] cmd = input.Split();
                int index = int.Parse(cmd[1]);
                int num2 = int.Parse(cmd[2]);
                if (cmd[0] == "merge")
                {
                    int startIndex = Math.Max(index, 0);
                    int ednIndex = Math.Min(num2, list.Count - 1);
                    int count = ednIndex - startIndex;
                    while (count > 0)
                    {
                        count--;
                        list[startIndex] += list[startIndex + 1];
                        list.RemoveAt(startIndex + 1);
                    }
                }
                else if (cmd[0] == "divide")
                {
                    string temp = list[index];
                    list.RemoveAt(index);
                    int substringsLenght = temp.Length / num2;
                    for (int i = 1; i < num2; i++)
                    {
                        list.Insert(index++, temp.Substring(0, substringsLenght));
                        temp = temp.Substring(substringsLenght);
                    }
                    list.Insert(index, temp);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
