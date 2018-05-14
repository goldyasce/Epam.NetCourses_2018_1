using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter HTML text: ");
            string HTML = Console.ReadLine();
            Regex regex = new Regex("<.*?>");
            string newHtml = regex.Replace(HTML, "_");
            Console.WriteLine(newHtml);

            Console.ReadKey();
        }
    }
}
