using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Interfaces;
using System.Windows;

namespace Shapes
{
    public class Line : Figure
    {
        private Point xcoor;
        private Point ycoor;

        public Line(Point xcoor, Point ycoor)
        {
            this.xcoor = xcoor;
            this.ycoor = ycoor;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawLine(xcoor, ycoor);
        }
    }
}
