using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text with time: ");
            string number = Console.ReadLine();
            int counter = Regex.Matches(number, "(^|\\b)([0-1][0-9]:[0-5][0-9])|([2][0-3]:[0-5][0-9])|([0-9]:[0-5][0-9])\b").Count;
            Console.WriteLine($"Время встречается {counter} раз.");

            Console.ReadKey();
        }
    }
}
