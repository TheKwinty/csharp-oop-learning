using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Lesson01.Hometask02.Books
{
    internal class Title
    {
        private string? title;

        public string TitleContent
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Title missing";
            }

            set
            {
                title = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(TitleContent);
        }
    }
}


