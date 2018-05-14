using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Interfaces;
using System.Windows;

namespace Shapes
{
    public class Rectangle : Figure
    {
        private Point xcoor;
        private Point ycoor;

        public Rectangle(Point xcoor, Point ycoor)
        {
            this.xcoor = xcoor;
            this.ycoor = ycoor;
            if (xcoor.X == ycoor.X || xcoor.Y == ycoor.Y)
            {
                throw new Exception("Это не прямоугольник!");
            }
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRect(xcoor, ycoor);
        }
    }
}
