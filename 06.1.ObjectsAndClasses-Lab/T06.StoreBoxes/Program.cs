using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.StoreBoxes
{
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(int serialNum, Item item, int quantity)
        {
            SerialNumber = serialNum;
            Item = item;
            ItemQuantity = quantity;
            PriceForABox = ItemQuantity * Item.Price;
        }

        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] info = input.Split();
                int serialNum = int.Parse(info[0]);
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                decimal itemPrice = decimal.Parse(info[3]);
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNum, item, itemQuantity);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
