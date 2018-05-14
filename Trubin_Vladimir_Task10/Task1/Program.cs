using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunc;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graduation grad = new Graduation();
            Console.WriteLine(grad.Grad(2, 10));

            Factorial fact = new Factorial();
            Console.WriteLine(fact.Fact(7));
            fact.GetHashCode();

            Console.ReadKey();
        }
    }
}
