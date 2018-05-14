using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Regex rgx1 = new Regex("^[-0-9]*[.,]?[0-9]+$");
            Regex rgx2 = new Regex("^[-0-9][.,][0-9]*[Ee][-0-9]+$");
            if (rgx1.IsMatch(number))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (rgx2.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }

            Console.ReadKey();

        }
    }
}
