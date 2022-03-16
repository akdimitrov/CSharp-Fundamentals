using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex barcodPattern = new Regex(@"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                if (barcodPattern.IsMatch(barcode))
                {
                    string group = string.Join("", barcode.Where(x => char.IsDigit(x)));
                    group = group == string.Empty ? "00" : group;
                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}
