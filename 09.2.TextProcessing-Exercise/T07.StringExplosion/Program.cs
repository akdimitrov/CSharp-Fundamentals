using System;
using System.Text;

namespace T07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>' && i < text.Length - 1)
                {
                    counter += int.Parse(text[i + 1].ToString());
                }
                else if (counter > 0)
                {
                    text.Remove(i--, 1);
                    counter--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
