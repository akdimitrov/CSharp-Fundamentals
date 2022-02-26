using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace T05.BookLibrary
{
    class Library
    {
        public Library()
        {
            Books = new List<Book>();
            Authors = new List<Author>();
        }
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public List<Author> Authors { get; set; }

    }

    class Book
    {
        public Book(string title, string author, string publisher, DateTime date, int isbn, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = date;
            ISBN = isbn;
            Price = price;
        }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int ISBN { get; set; }

        public double Price { get; set; }
    }

    class Author
    {
        public Author(string name, double total)
        {
            Name = name;
            TotalSum = total;
        }
        public string Name { get; set; }

        public double TotalSum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();
                AdBooks(library, array);
            }

            foreach (var author in library.Authors.OrderByDescending(n => n.TotalSum).ThenBy(n => n.Name))
            {
                Console.WriteLine($"{author.Name} -> {author.TotalSum:f2}");
            }

        }

        public static void AdBooks(Library library, string[] array)
        {
            string title = array[0];
            string authorName = array[1];
            string publisher = array[2];
            DateTime releaseDate = DateTime.ParseExact(array[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            int isbn = int.Parse(array[4]);
            double price = double.Parse(array[5]);

            Book book = new Book(title, authorName, publisher, releaseDate, isbn, price);
            library.Books.Add(book);

            if (library.Authors.Any(n => n.Name == authorName))
            {
                var author = library.Authors.First(n => n.Name == authorName);
                author.TotalSum += price;
            }
            else
            {
                Author authror = new Author(authorName, price);
                library.Authors.Add(authror);
            }
        }
    }
}
