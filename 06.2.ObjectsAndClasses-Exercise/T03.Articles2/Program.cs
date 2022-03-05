using System;
using System.Collections.Generic;

namespace T03.Articles2
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(", ");
                string title = text[0];
                string content = text[1];
                string author = text[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string input = Console.ReadLine();
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
