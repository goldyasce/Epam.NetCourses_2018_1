﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N: ");
            int line = Int32.Parse(Console.ReadLine());
            int space = line - 1;
            int numberofstars = 1;
            for (int i = 0; i < line; i++)
            {

                string wspace = new string(' ', space);
                string star = new string('*', numberofstars);
                space--;
                numberofstars += 2; 
                Console.WriteLine(wspace + star);
            }
            Console.ReadKey();
        }
    }
}
