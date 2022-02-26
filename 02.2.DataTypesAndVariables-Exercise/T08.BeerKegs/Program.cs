using System;

namespace T08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            string biggestKegModel = string.Empty;
            double highestVolume = double.MinValue;
            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radius * radius * height;
                if (currentVolume > highestVolume)
                {
                    highestVolume = currentVolume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
