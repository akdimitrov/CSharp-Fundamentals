using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.AndreyAndBilliard
{
    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }

    class Client
    {
        public Client(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public double Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Client> clients = new List<Client>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string name = input[0];
                double price = double.Parse(input[1]);
                Product product = new Product(name, price);
                if (products.Any(p => p.Name == name))
                {
                    Product productToUpdate = products.First(p => p.Name == name);
                    productToUpdate.Price = price;
                }
                else
                {
                    products.Add(product);
                }
            }

            string command = Console.ReadLine();
            while (command != "end of clients")
            {
                string[] array = command.Split('-', ',');
                string clientName = array[0];
                string productName = array[1];
                int quantity = int.Parse(array[2]);
                if (products.Any(p => p.Name == productName) && quantity > 0)
                {
                    if (clients.Any(c => c.Name == clientName))
                    {
                        Client clientToUpdate = clients.First(c => c.Name == clientName);
                        if (clientToUpdate.Products.Any(p => p.Name == productName))
                        {
                            Product productToUpdate = clientToUpdate.Products.First(p => p.Name == productName);
                            productToUpdate.Quantity += quantity;
                        }
                        else
                        {
                            var productToAdd = products.First(p => p.Name == productName);
                            Product newProduct = new Product(productToAdd.Name, productToAdd.Price);
                            newProduct.Quantity = quantity;
                            clientToUpdate.Products.Add(newProduct);
                        }
                    }
                    else
                    {
                        Client client = new Client(clientName);
                        var productToAdd = products.First(p => p.Name == productName);
                        Product newProduct = new Product(productToAdd.Name, productToAdd.Price);
                        newProduct.Quantity = quantity;
                        client.Products.Add(newProduct);
                        clients.Add(client);
                    }
                }

                command = Console.ReadLine();
            }

            double totalBill = 0;
            foreach (var client in clients.OrderBy(c => c.Name))
            {
                Console.WriteLine(client.Name);
                double clientBill = 0;
                foreach (var product in client.Products)
                {
                    Console.WriteLine($"-- {product.Name} - {product.Quantity}");
                    clientBill += product.Quantity * product.Price;
                }
                totalBill += clientBill;
                Console.WriteLine($"Bill: {clientBill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
