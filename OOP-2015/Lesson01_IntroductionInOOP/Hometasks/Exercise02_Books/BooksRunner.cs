using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask02.Books
{
    static class BooksRunner
    {
        static public void Run()
        {
            Title bookTitle1 = new Title();
            bookTitle1.TitleContent = "Once upon a broken heart.";

            Author bookAuthor1 = new Author();
            bookAuthor1.AuthorContent = "Stephanie Garber.";

            Content bookContent1 = new Content();
            bookContent1.ContentContent = "Romantasy novel";

            Book book1 = new Book(bookTitle1, bookAuthor1, bookContent1);
            book1.Show();

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(new string ('=',50));
            Console.WriteLine();

            Book book2 = new Book(
                bookTitle: bookTitle1,
                bookAuthor: bookAuthor1,
                bookContent: bookContent1); //можна будувати об'єкт і так і так

            book2.Show();
            Console.ResetColor();

        }
    }
}
