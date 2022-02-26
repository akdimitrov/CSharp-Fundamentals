using System;

namespace T04.MorseCodeUpgr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|");
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                int repCounter = 0;
                char last = ' ';
                foreach (var item in array[i])
                {
                    sum += item == '0' ? 3 : 5;

                    if (item == last)
                    {
                        repCounter++;
                        sum++;
                        if (repCounter == 1)
                        {
                            repCounter++;
                            sum++;
                        }
                    }
                    else
                    {
                        repCounter = 0;
                    }
                    last = item;
                }
                array[i] = ((char)sum).ToString();
            }

            Console.WriteLine(String.Join("", array));
        }
    }
}
