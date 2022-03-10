using System;
using System.Text;

namespace T05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder article = new StringBuilder();
            article.AppendLine("<h1>");
            article.AppendLine($"    {Console.ReadLine()}");
            article.AppendLine("</h1>");
            article.AppendLine("<article>");
            article.AppendLine($"    {Console.ReadLine()}");
            article.AppendLine("</article>");

            string comment = Console.ReadLine();
            while (comment != "end of comments")
            {
                article.AppendLine("<div>");
                article.AppendLine($"    {comment}");
                article.AppendLine("</div>");
                comment = Console.ReadLine();
            }
            Console.WriteLine(article);
        }
    }
}
