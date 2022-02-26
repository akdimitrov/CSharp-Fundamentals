using System;

namespace T09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabers = lightsaberPrice * Math.Ceiling(students * 1.1);
            double belts = beltPrice * students - beltPrice * (int)(students / 6);
            double robes = robePrice * students;
            double total = sabers + belts + robes;

            if (total <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
        }
    }
}
