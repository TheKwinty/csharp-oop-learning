using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask02.Books
{
    internal class Content
    {
        private string? content;

        public string ContentContent
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Content missing!";
            }

            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ContentContent);
            Console.ResetColor();
        }
    }
}
