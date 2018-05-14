using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            Console.Write("Enter array size Z: ");
            int arraysizez = Int32.Parse(Console.ReadLine());

            int[,,] array = new int[arraysizex, arraysizey, arraysizez];
            Rand(array);
            Change(array);

            Console.ReadKey();
        }
        static int[,,] Rand(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        array[i,j,z] = rnd.Next(-1000, 1000);
                    }
                } 
            }
            return array;
        }
        static int[,,] Change (int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        if (array[i, j, z] < 0)
                        {
                            array[i, j, z] = 0;
                        }
                    }
                }
            }
            return array;
        }
    }
}
