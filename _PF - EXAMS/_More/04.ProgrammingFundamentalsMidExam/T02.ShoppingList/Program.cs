using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();
            string action = Console.ReadLine();
            while (action != "Go Shopping!")
            {
                string[] command = action.Split();
                if (command[0] == "Urgent")
                {
                    if (!shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                        shoppingList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    shoppingList.Remove(command[1]);
                }
                else if (command[0] == "Correct")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int index = shoppingList.IndexOf(command[1]);
                        shoppingList[index] = command[2];
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                        shoppingList.Add(command[1]);
                    }
                }

                action = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
