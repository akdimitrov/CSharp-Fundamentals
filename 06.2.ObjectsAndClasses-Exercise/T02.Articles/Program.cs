using System;

namespace T02.Articles
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");
            string title = text[0];
            string content = text[1];
            string author = text[2];
            Article article = new Article(title, content, author);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string action = input[0];
                string newValue = input[1];
                switch (action)
                {
                    case "Edit": article.Edit(newValue); break;
                    case "ChangeAuthor": article.ChangeAuthor(newValue); break;
                    case "Rename": article.Rename(newValue); break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
