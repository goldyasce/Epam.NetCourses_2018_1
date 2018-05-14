using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double radius;

        public double Xcoordinate { get; set; }

        public double Ycoordinate { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Wrong radius");
                }
            }
        }

        public Round(double x, double y, double radius)
        {
            Xcoordinate = x;
            Ycoordinate = y;
            Radius = radius;
        }

        public double Square(double round)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Length(double round)
        {
            return Math.PI * radius * 2;
        }
    }
}
