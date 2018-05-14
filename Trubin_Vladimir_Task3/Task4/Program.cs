using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch w = new Stopwatch();
            int n = 100;
            w.Start();
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }

            w.Stop();
            Console.WriteLine($"String: {w.Elapsed.TotalMilliseconds}");
            w.Reset();
            w.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }

            w.Stop();
            Console.WriteLine($"StringBuilder: {w.Elapsed.TotalMilliseconds}");

            
            Console.ReadKey();
        }
    }
}
