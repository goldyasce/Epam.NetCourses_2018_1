using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    class Program
    {
        public delegate void PrintArray(string[] str);
        static public event PrintArray FinishSort;

        static void Main(string[] args)
        {
            var strArray1 = new string[] { "there", "is", "water", "on", "the", "floor" };
            var strArray2 = new string[] { "there", "is", "water", "on", "the", "floor" };
            FinishSort += Print;
            ThreadStart sorting = () =>
            {
                strArray1 = SortArray(strArray1);
            };
            Thread newThread = new Thread(sorting);
            ThreadStart sorting1 = () =>
            {
                strArray1 = SortArray(strArray2);
            };
            Thread newThread2 = new Thread(sorting1);
            newThread.Start();
            newThread2.Start();
            Console.ReadKey();
        }

        static public void Print(string[] str)
        {
            Console.WriteLine(String.Join(" ", str));
        }

        static public string[] SortArray(string[] str)
        {
            string temp;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (CompareElemByLength(str[i], str[j]) != 0)
                    {
                        if (CompareElemByLength(str[i], str[j]) == -1)
                        {
                            temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                    Thread.Sleep(100);
                }
            }
            FinishSort(str);
            return str;
        }
        static public int CompareElemByLength(string firstElem, string secondElem)
        {
            if (firstElem.Length > secondElem.Length)
            {
                return -1;
            }
            else
            {
                if (firstElem.Length < secondElem.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

