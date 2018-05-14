using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Int32.Parse(Console.ReadLine());
            int square = 0;
            if (a <= 0 | b <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                square = a * b;
                Console.WriteLine("Square = {0}", square);
            }
           
            
            Console.ReadKey();

        }
    }
}
