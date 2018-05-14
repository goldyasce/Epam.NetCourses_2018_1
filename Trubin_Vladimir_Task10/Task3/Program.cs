using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> hash = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                for (var j = 0; j < 1000; j++)
                {
                    Hash point = new Hash(i, j);
                    hash.Add(point.GetHashCode());
                }
            }
            List<int> uniq = hash.Distinct().ToList();
            Console.WriteLine($"All count = {hash.Count}");
            Console.WriteLine($"Uniq count = {uniq.Count}");
            Console.WriteLine($"The same count = {hash.Count - uniq.Count}");
            double sameCount = (double)(hash.Count - uniq.Count) * 100 / (double)hash.Count;
            Console.WriteLine($"{sameCount}%");


            Console.ReadKey();
        }
    }
}
