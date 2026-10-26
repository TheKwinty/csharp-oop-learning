using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask03.Figure
{
    internal class Figure
    {
        private Point point, point1, point2;
        private Point? point3, point4;
        public Figure(Point point, Point point1, Point point2)
        {
            this.point = point;
            this.point1 = point1;
            this.point2 = point2;
        }

        public Figure(Point point, Point point1, Point point2, Point point3)
        {
            this.point = point;
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public Figure(Point point, Point point1, Point point2, Point point3, Point point4)
        {
            this.point = point;
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.AxisValueX - A.AxisValueX ,2) + Math.Pow( B.AxisValueY - A.AxisValueY, 2));
        } 

        public void PerimeterCalculator()
        {
            double perimeter = LengthSide(point, point1) + LengthSide(point1, point2);
            string nameOfFigure = point.NamePoint + point1.NamePoint + point2.NamePoint; 

            Point lastPoint = point2;

            if (point3 != null)
            {
                perimeter += LengthSide(lastPoint, point3);
                lastPoint = point3;
                nameOfFigure += lastPoint.NamePoint;
            }

            if (point4 != null)
            {
                perimeter += LengthSide(lastPoint, point4);
                lastPoint = point4;
                nameOfFigure += lastPoint.NamePoint;
            }

            perimeter += LengthSide(lastPoint, point);

            Console.WriteLine($"Figure {nameOfFigure} has perimeter {perimeter}");

        }

    }
}
