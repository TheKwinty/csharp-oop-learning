using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask02.Books
{
    internal class Author
    {
        private string? author;

        public string AuthorContent
        {
            private get
            {
                if (author != null)
                    return author;
                else
                    return "Author missing";
            }
            set
            {
                author = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(AuthorContent);
        }
    }
}
