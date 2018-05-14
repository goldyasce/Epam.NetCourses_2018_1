using System;
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
            MyString firstString = new MyString("Hello my dear friend");
            MyString secondString = new MyString("Hi my dear friend");
            if (firstString.Equals(secondString))
            {
                Console.WriteLine("Lines are equal");
            }
            if (firstString != secondString)
            {
                Console.WriteLine("Lines are not equal");
            }
            firstString += "! How are you?";
            Console.WriteLine(firstString.ToString());
            firstString -= "How";
            Console.WriteLine(firstString.ToString());
            Console.ReadKey();
        }
    }
}
