using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    delegate void PersonCame(Person p, DateTime date);
    delegate void PersonGone(Person p);

    class Person
    {
        public event PersonCame Came;
        public event PersonGone Gone;

        public string PersonName { get; set; }


        public void GoToWork ()
        {
            Came(this, DateTime.Now);
        }

        public void OnGone ()
        {
            Gone(this);
        }

        public void Greatings (Person person, DateTime commingTime)
        {
            if (commingTime.TimeOfDay.Hours < 12)
            {
                Console.WriteLine($"Good morning, {PersonName}!");
            }
            else if (commingTime.TimeOfDay.Hours < 17)
            {
                Console.WriteLine($"Good afternoon, {PersonName}!");
            }
            else
            {
                Console.WriteLine($"Good evenig, {PersonName}!");
            }
        }


        public void Goodbye (Person person)
        {
            Console.WriteLine($"Goodbye, {PersonName}!");
        }


    }
}
