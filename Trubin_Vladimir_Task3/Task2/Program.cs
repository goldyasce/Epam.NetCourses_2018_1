using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first line: ");
            string first_line = Console.ReadLine();
            Console.Write("Enter second line: ");
            string second_line = Console.ReadLine();
            string second_unique = FindDoudle(second_line);
            Console.WriteLine($"Doubled line: {DoubleChar(first_line, second_unique)}");
            Console.ReadKey();
        }
        static string FindDoudle(string second_line)
        {
            string new_line = string.Empty;
            List<char> char_list = new List<char>();
            foreach (char chars in second_line)
            {
                if (char_list.Contains(chars))
                {
                    continue;
                }
                new_line += chars.ToString();
                char_list.Add(chars);
            }

            return new_line;
        }
        static string DoubleChar(string first_line, string second_unique)
        {
            for (int j = 0; j < second_unique.Length; j++)
            {
                var c = second_unique[j];
                first_line = first_line.Replace(c.ToString(), new string(c, 2));
            }

            return first_line;
        }
    }
}
    

