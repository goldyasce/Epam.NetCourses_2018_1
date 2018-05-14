using System;
using DemoApplication;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new GeomProg(2, 3);
            InterfacesDemo.PrintSeries(gp);
            Console.ReadKey();
        }
    }
}
