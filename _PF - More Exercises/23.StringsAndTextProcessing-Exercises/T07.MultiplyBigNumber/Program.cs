using System;
using System.Text;

namespace T07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            string result = "0";
            int remainder = 0;
            if (multiplier > 0)
            {
                StringBuilder product = new StringBuilder();
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    int currentProduct = int.Parse(num[i].ToString()) * multiplier + remainder;
                    product.Insert(0, currentProduct % 10);
                    remainder = currentProduct / 10;

                    if (i == 0 && remainder > 0)
                    {
                        product.Insert(0, remainder);
                    }
                }
                while (product[0] == '0' && product.Length > 1)
                {
                    product.Remove(0, 1);
                }
                result = product.ToString();
            }

            Console.WriteLine(result);
        }
    }
}
