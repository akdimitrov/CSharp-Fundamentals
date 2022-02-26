using System;

namespace T01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            bool isEnough = true;
            for (int day = 1; day <= 30; day++)
            {
                food -= 0.3m;
                if (day % 2 == 0)
                {
                    hay -= food * 0.05m;
                }
                if (day % 3 == 0)
                {
                    cover -= weight / 3;
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    isEnough = false;
                    break;
                }
            }

            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
