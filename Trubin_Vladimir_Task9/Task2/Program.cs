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
            Person pers = new Person();
            Person pers1 = new Person();
            Person pers2 = new Person();
            Person pers3 = new Person();
            pers.PersonName = "Steve";
            pers1.PersonName = "Bob";
            pers2.PersonName = "Rob";
            pers3.PersonName = "Elli";
            Office office = new Office();
            office.AddWorker(pers, DateTime.Now);
            office.AddWorker(pers1, DateTime.Now);
            office.AddWorker(pers2, DateTime.Now);
            office.RemoveWorker(pers);
            office.AddWorker(pers3, DateTime.Now);
            office.RemoveWorker(pers3);

            Console.ReadKey();
        }
    }
}
