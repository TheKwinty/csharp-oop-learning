using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask03.Figure
{
    static class FigureRunner
    {
        static public void Run()
        {
            Point point1 = new Point(3, 4, "A");
            Point point2 = new Point(-4, 45, "B");
            Point point3 = new Point(1, 4, "C");
            Point point4 = new Point(-90, 8, "D");
            Point point5 = new Point(11, 103, "E");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.PerimeterCalculator();

            Figure quadrilateral = new Figure(point1, point2, point3, point4);
            quadrilateral.PerimeterCalculator();

            Figure pentagon = new Figure(point1, point2, point3, point4, point5);
            pentagon.PerimeterCalculator();
        }
       

        
    }
}
