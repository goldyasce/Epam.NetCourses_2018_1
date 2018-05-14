using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Figures.Interfaces;

namespace ConsoleCanvas
{
    public class Canvas : ICanvas
    {
        public void DrawLine(Point xcoor, Point ycoor)
        {
            Console.WriteLine($"Линия ({xcoor.X}, {xcoor.Y}) ({ycoor.X}, {ycoor.Y})");
        }

        public void DrawRect(Point xcoor, Point ycoor)
        {
            Console.WriteLine($"Прямоугольник ({xcoor.X}, {xcoor.Y}), ({ycoor.X}, {ycoor.Y})");
        }

        public void DrawRound(Point point, double radius)
        {
            Console.WriteLine($"Круг ({point.X}, {point.Y}) с радиусом {radius}");
        }
    }
}
