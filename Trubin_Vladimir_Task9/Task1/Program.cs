using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "we", "are", "a", "global", "team", "of", "tecno" };
            CompareString compareStr = new CompareString(CompareElemByAlphabet);
            strArray = SortArray(strArray, compareStr);
            compareStr = new CompareString(CompareElemByLength);
            strArray = SortArray(strArray, compareStr);
            Console.WriteLine(String.Join(" ", strArray));

            Console.ReadKey();
        }

        public delegate int CompareString(string firstElem, string secondElem);

        static public string[] SortArray (string[] str, CompareString compareStr)
        {
            if (compareStr != null)
            {
                string temp;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (compareStr(str[i], str[j]) != 0)
                        {
                            if (compareStr(str[i], str[j]) == -1)
                            {
                                temp = str[i];
                                str[i] = str[j];
                                str[j] = temp;
                            }
                        }
                    }
                }
                return str;
            }
            else
            {
                throw new ArgumentException("Delegate is null");
            }
        }

        static public int CompareElemByLength (string firstElem, string secondElem)
        {
            if (firstElem.Length > secondElem.Length)
            {
                return -1;
            }
            else
            {
                if (firstElem.Length > secondElem.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        static public int CompareElemByAlphabet (string firstElem, string secondElem)
        {
            return String.Compare(firstElem, secondElem);
        }
    }
}
