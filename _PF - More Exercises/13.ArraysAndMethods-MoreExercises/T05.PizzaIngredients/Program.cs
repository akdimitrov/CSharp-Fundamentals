using System;

namespace T05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            string addedIngrediets = "";
            int counter = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == n)
                {
                    counter++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    if (counter == 1)
                    {
                        addedIngrediets += ingredients[i];
                    }
                    else
                    {
                        addedIngrediets += $", {ingredients[i]}";
                    }
                }

                if (counter == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {addedIngrediets}.");
        }
    }
}
