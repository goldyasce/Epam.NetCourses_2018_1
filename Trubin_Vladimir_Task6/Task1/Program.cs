using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCanvas;
using Shapes;
using System.Windows;
using Figures.Interfaces;
using System.Drawing;

namespace Task1
{
    class Program
    {
        public static Point RandomPoint()
        {
            Point res = new Point();
            res.X = randomGenerator.Next(-10, 10);
            res.Y = randomGenerator.Next(-10, 10);
            return res;
        }

        public static double RandomRadius()
        {
            return randomGenerator.Next(1, 10);
        }

        static Random randomGenerator = new Random();

        static void Main(string[] args)
        {
            Figure[] fig = new Figure[3];

            for (int i = 0; i < fig.Length; i++)
            {
                switch (randomGenerator.Next(4))
                {
                    case 0:
                        fig[i] = new Line(RandomPoint(), RandomPoint());
                        break;
                    case 1:
                        fig[i] = new Round(RandomPoint(), RandomRadius());
                        break;
                    case 2:
                        fig[i] = new Ring(RandomPoint(), RandomRadius(), RandomRadius());
                        break;
                    case 3:
                        fig[i] = new Rectangle(RandomPoint(), RandomPoint());
                        break;
                }
            }

            Canvas console = new Canvas();

            for (int i = 0; i < fig.Length; i++)
            {
                fig[i].Draw(console);
            }

            Console.ReadKey();
        }
    }
}
