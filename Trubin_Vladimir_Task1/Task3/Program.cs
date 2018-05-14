using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int s = 0, s1 = 0, s2 = 0, s3 = 0;

            Stopwatch w = new Stopwatch();
            w.Start();
            for (int i = 0; i < n; i++)
            {
                if (i%3 == 0 | i%5 == 0)
                {
                    s = s + i;
                }
            }
            w.Stop();
            Console.WriteLine($"1: {w.Elapsed.TotalMilliseconds}");
            Console.WriteLine($"s: {s}");

            w.Reset();
            w.Start();
            for (int i = 0; i < n; i += 5)
            {
                if (i % 3 != 0)
                {
                    s1 += i;
                }
                
            }
            for (int i = 0; i < n; i += 3)
            {
                s2 += i;
            }
            s3 = s1 + s2;
            w.Stop();
            Console.WriteLine($"2: {w.Elapsed.TotalMilliseconds}");
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
