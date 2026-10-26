using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask02.Books
{
    internal class Book
    {
        private Title? bookTitle;
        private Author? bookAuthor;
        private Content? bookContent;

        public Book(Title? bookTitle, Author? bookAuthor, Content? bookContent)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.bookContent = bookContent;
        }

        public void Show()
        {
            this.bookTitle?.Show();
            this.bookAuthor?.Show();
            this.bookContent?.Show();
        }
    }
}
