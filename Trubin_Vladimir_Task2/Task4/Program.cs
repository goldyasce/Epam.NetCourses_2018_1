using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Enter array size X: ");
            int arraysizex = Int32.Parse(Console.ReadLine());
            Console.Write("Enter array size Y: ");
            int arraysizey = Int32.Parse(Console.ReadLine());
            int[,] myarray = new int[arraysizex, arraysizey];
            Rand(myarray);
            Display(myarray);
            Console.WriteLine($"Summa: {Sum(myarray)}");

            Console.ReadKey();
        }
        static int[,] Rand(int[,] myarray)
        {
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    myarray[i, j] = rnd.Next(0, 11);
                }
            }
            return myarray;
        }
        static int Sum(int[,] myarray)
        {
            int sum = 0;
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += myarray[i, j];
                    }
                }
            }
            return sum;
        }
        static void Display(int[,] myarray)
        {
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write($"\t{myarray[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
