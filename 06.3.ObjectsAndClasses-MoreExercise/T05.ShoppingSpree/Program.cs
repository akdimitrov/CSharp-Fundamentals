using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.ShoppingSpree
{
    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public double Cost { get; set; }
    }

    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public double Money { get; set; }

        public List<Product> Products { get; set; }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                Products.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] allPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            foreach (var person in allPeople)
            {
                string[] info = person.Split("=");
                string name = info[0];
                double money = double.Parse(info[1]);
                people.Add(new Person(name, money));
            }

            string[] allProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            foreach (var product in allProducts)
            {
                string[] info = product.Split("=");
                string name = info[0];
                double cost = double.Parse(info[1]);
                products.Add(new Product(name, cost));
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] order = input.Split();
                string person = order[0];
                string product = order[1];
                people.First(x => x.Name == person).BuyProduct(products.First(x => x.Name == product));

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
                }
            }
        }
    }
}
