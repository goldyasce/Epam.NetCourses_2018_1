using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Interfaces;
using System.Windows;

namespace Shapes
{
    public class Ring : Round
    {
        protected double innerR;

        public Ring(Point point, double radius, double innerR) : base(point, radius)
        {
            this.innerR = innerR;
            if (radius == innerR)
            {
                throw new Exception("Радиусы должны быть разные!");
            }
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(point, innerR);
            canvas.DrawRound(point, radius);
        }
    }
}
