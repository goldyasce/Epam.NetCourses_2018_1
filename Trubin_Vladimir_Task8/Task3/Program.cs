using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Rect RECT, rect fiNd. find FIND text";
            string[] strArray = DeleteSpacesAndPunct(str);
            var numOfWords = strArray.Length;
            var uniqueStr = strArray.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            int[] numOfIntromission = new int[uniqueStr.Length];
            List<KeyValuePair<string, double>> wordAndNum = new List<KeyValuePair<string, double>>();

            FindingWords(uniqueStr, numOfIntromission, str, wordAndNum, numOfWords);

            Console.WriteLine(str);
            
            wordAndNum.Sort(new ValueComparer<string, double>());
            Write(wordAndNum, wordAndNum.Count);
            Console.ReadKey();
        }

        static string[] DeleteSpacesAndPunct (string s)
        {
            Regex rgx = new Regex("\\W");
            string[] wordsOnly = rgx.Split(s).Where(str => str != String.Empty).ToArray();
            return wordsOnly;
        }

        private static void FindingWords (string[] words, int[] count, string sourse, 
            List<KeyValuePair<string, double>> list, int numberOfWords)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string pattern = "\\b(?i)" + words[i] + "(?-i)\\b";
                count[i] = new Regex(pattern).Matches(sourse).Count;
                list.Add(new KeyValuePair<string, double>(words[i], count[i]));
            }
        }

        private static void Write(List<KeyValuePair<string, double>> list, int numberOfIteration)
        {
            for (int i = 0; i < numberOfIteration; i++)
            {
                Console.WriteLine("{0}: {1}", list[i].Key, list[i].Value);
            }
        }

        public class ValueComparer<Tkey, TValue> : IComparer<KeyValuePair<Tkey, TValue>> where TValue : IComparable
        {
            public int Compare (KeyValuePair<Tkey, TValue> x, KeyValuePair<Tkey, TValue> y)
            {
                return y.Value.CompareTo(x.Value);
            }
        }
    }
}
