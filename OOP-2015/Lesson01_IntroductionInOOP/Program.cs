using Lesson01.Hometask01.Rectangle;
using Lesson01.Hometask02.Books;
using Lesson01.Hometask03.Figure;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson01_IntroductionInOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Домашнє завдання №1. Вступ в ООП, класи і об'єкти.");
                Console.WriteLine();

                Console.WriteLine("0 - Вихід із програми");
                Console.WriteLine("1 - Завдання №1. Прямокутник (площа і периметр.)");
                Console.WriteLine("2 - Завдання №2. Книги");
                Console.WriteLine("3 - Завдання №3. Багатокутник. Вимірювання периметра фігури.");

                Console.WriteLine("\nОберіть номер завдання для перевірки: ");

            
               
                switch (Console.ReadLine())
                {
                    case "0":
                        return;
                    case "1":
                        RectangleRunner.Run();
                        break;
                    case "2":
                        BooksRunner.Run();
                        break;
                    case "3":
                        FigureRunner.Run();
                        break;

                    default:
                        Console.WriteLine("Такого завдання не існує, спробуйте ще раз!");
                        break;
                }

                Console.ReadKey();
            }
           


        }
    }
}
