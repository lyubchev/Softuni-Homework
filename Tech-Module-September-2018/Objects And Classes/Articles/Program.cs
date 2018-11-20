using System;

namespace Articles
{
    class Article
    {
        private string title;
        private string content;
        private string author;

        public Article(string[] data)
        {
            this.title = data[0];
            this.content = data[1];
            this.author = data[2];
        }

        public void Edit(string newContent)
        {
            this.content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.title} - {this.content}: {this.author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // GOTTA SAVE THAT MEMORY 
            string[] parameters = Console.ReadLine().Split(", ");

            Article article = new Article(parameters);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; n++)
            {
                string command = Console.ReadLine();

                switch (command.Split(":")[0])
                {
                    case "Edit":
                        article.Edit(command.Split()[1].TrimStart());
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command.Split()[1].TrimStart());
                        break;
                    case "Rename":
                        article.Rename(command.Split()[1].TrimStart());
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
