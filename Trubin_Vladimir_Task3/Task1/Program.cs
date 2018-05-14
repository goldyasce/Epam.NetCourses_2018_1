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
            Console.Write("Enter text: ");
            string line = Console.ReadLine();
            Console.WriteLine($"Average: {Average(line)}");

            Console.ReadKey();
        }
        static int Average(string line)
        {
            int nchars = 0;
            int nwords = 0;
            var punct = new List<char>();
            for (int i = 0; i < line.Length; i++)
            {
                if (!Char.IsLetter(line[i]))
                {
                    punct.Add(line[i]);
                }
            }
            string[] substr = line.Split(punct.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int countOfWords = substr.Length;
            int charCount = 0;
            for (int i = 0; i < substr.Length; i++)
            {
                var word = substr[i];
                charCount += word.Length;
            }

            nwords += 1;
            int avg = nchars / nwords;

            return avg;
        }
    }
}
