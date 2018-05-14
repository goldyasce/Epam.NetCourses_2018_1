using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public Triangle()
        { }
            

        public Triangle(double ina, double inb, double inc)
        {
            if ((inb + inc > ina) && (ina + inc > inb) && (ina + inb > inc))
            {
                SideA = ina;
                SideB = inb;
                SideC = inc;
            }
        }

        public double SideA
        {
            get;
            private set;
        }

        public double SideB
        {
            get;
            private set;
        }

        public double SideC
        {
            get;
            private set;
        }

        public double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double Perimetr()
        {
            return SideA + SideB + SideC;
        }
    }
}
