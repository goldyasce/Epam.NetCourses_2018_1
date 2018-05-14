using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTest_Demo
{
    public class Car
    {
        public Car()
        {
            System.Console.WriteLine("The Car constructor invoked.");
        }
    }
    public class Bus : Car
    {
        public Bus()
        {
            System.Console.WriteLine("The Bus constructor invoked.");
        }

        public void Drive()
        {
            System.Console.WriteLine("The Drive method invoked.");
        }
    }


    class Program 
    {
        static void Main()
        {
            new Bus().Drive();

            Console.ReadKey();
        }

    }

}





