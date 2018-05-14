using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
            Sorting(myarray);
            Display(myarray);
            Console.WriteLine($"Maximum: {Max(myarray)}");
            Console.WriteLine($"Minimum: {Min(myarray)}");

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
        static int Max(int[] myarray)
        {
            int max = int.MinValue;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > max)
                {
                    max = myarray[i];
                }
            }
            return max;
        }
        static int Min(int[] myarray)
        {
            int min = int.MaxValue;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] < min)
                {
                    min = myarray[i];
                }
            }
            return min;
        }
        static int[] Sorting(int[] myarray)
        {
            //BobleSort
            /*int temp;
            for (int i = 0; i < myarray.Length; i++)
            {
                for (int j = 0; j < myarray.Length - i - 1; j++)
                {
                    if (myarray[j] < myarray[j + 1])
                    {
                        temp = myarray[j + 1];
                        myarray[j + 1] = myarray[j];
                        myarray[j] = temp;
                    }
                }
            }*/
            //ShellSort
            int increment = 3;
            while (increment > 0)  
            {
                for (int i = 0; i < myarray.Length; i++) 
                {
                    int j = i;          
                    int temp = myarray[i];
                    while ((j >= increment) && (myarray[j - increment] > temp))
                    {
                        myarray[j] = myarray[j - increment]; 
                        j = j - increment;       
                    }
                    myarray[j] = temp; 
                }
                if (increment > 1)      
                    increment = increment / 2;
                else if (increment == 1)   
                    break;  
            }
                return myarray;
        }
        static void Display(int[] myarray)
        {
            Console.WriteLine(string.Join(", ", myarray));
        }
    }
}
