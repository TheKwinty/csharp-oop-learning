using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask01.Rectangle
{
    class RectangleRunner
    {
        static public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle spongeBobSquarePants = new Rectangle(length, width);

            Console.WriteLine($"Area = {spongeBobSquarePants.Area}, Perimeter = {spongeBobSquarePants.Perimeter}");

        }
    }
}
