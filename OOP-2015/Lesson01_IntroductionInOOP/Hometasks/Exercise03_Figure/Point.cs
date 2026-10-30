using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01.Hometask03.Figure
{
    internal class Point
    {
        private int axisX, axisY;// точки на осі координат
        private string? namePoint;//назва точки

        public int AxisValueX { get { return axisX; } }
        public int AxisValueY { get { return axisY; } }
        public string? NamePoint { get { return namePoint; } }

        public Point(int axisX, int axisY, string? namePoint)
        {
            this.axisX = axisX;
            this.axisY = axisY;
            this.namePoint = namePoint;
            
        }
    }
}
