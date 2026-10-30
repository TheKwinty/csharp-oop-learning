using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask01.Rectangle
{
    internal class Rectangle
    {
        private double side1, side2;

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }


    }
}
