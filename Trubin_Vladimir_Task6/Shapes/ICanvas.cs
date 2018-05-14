using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Figures.Interfaces
{
    public interface ICanvas
    {
        void DrawLine(Point xcoor, Point ycoor);
        void DrawRound(Point xcoor, double radius);
        void DrawRect(Point xcoor, Point ycoor);
    }
}
