using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                if (!regex.IsMatch(barcode))
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string productGroup = barcode.Any(x => char.IsDigit(x)) ?
                    string.Join("", barcode.Where(x => char.IsDigit(x))) : "00";
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
