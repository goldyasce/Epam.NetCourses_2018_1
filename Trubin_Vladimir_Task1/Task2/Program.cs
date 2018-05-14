using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N: ");
            int line = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < i; j++)
                {
                   Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
