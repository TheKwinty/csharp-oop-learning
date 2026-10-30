using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask03.Figure
{
    internal class Figure
    {
        private Point pointA, pointB, pointC;
        private Point? pointD, pointE;
        public Figure(Point pointA, Point pointB, Point pointC)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
            this.pointE = pointE;
        }

        private double LengthSide(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.AxisValueX - firstPoint.AxisValueX ,2) + Math.Pow( secondPoint.AxisValueY - firstPoint.AxisValueY, 2));
        } 

        public void PerimeterCalculator()
        {
            double perimeter = LengthSide(pointA, pointB) + LengthSide(pointB, pointC);
            string nameOfFigure = pointA.NamePoint + pointB.NamePoint + pointC.NamePoint; 

            Point lastPoint = pointC;

            if (pointD != null)
            {
                perimeter += LengthSide(lastPoint, pointD);
                lastPoint = pointD;
                nameOfFigure += lastPoint.NamePoint;
            }

            if (pointE != null)
            {
                perimeter += LengthSide(lastPoint, pointE);
                lastPoint = pointE;
                nameOfFigure += lastPoint.NamePoint;
            }

            perimeter += LengthSide(lastPoint, pointA);

            Console.WriteLine($"Figure {nameOfFigure} has perimeter {perimeter}");

        }

    }
}
