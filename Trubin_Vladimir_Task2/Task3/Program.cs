using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arraysize = Int32.Parse(Console.ReadLine());
            int[] myarray = new int[arraysize];
            Rand(myarray);
            Display(myarray);
            Console.WriteLine($"Sum: {Sum(myarray)}"); 
            Console.ReadKey();
        }
        static int[] Rand(int[] myarray)
        {
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = rnd.Next(-1000, 1000);
            }
            return myarray;
        }
        static int Sum(int[] myarray)
        {
            int summa = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] >= 0)
                {
                    summa += myarray[i];
                }
            }
            return summa;
        }
        static void Display(int[] myarray)
        {
            Console.WriteLine(string.Join(", ", myarray));
        }
    }
}
