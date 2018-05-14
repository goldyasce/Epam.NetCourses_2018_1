using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        List<Person> workers = new List<Person>();
        delegate void Hello(Person name, DateTime time);
        delegate void Bye(Person name);
        Hello greet = null;
        Bye bye = null;

        public void AddWorker (Person person, DateTime time)
        {
            workers.Add(person);
            person.Came += PersonCame;
            person.GoToWork();
        }

        public void RemoveWorker (Person person)
        {
            workers.Remove(person);
            person.Gone += PersonGone;
            person.OnGone();
        }

        public void PersonCame(Person person, DateTime time)
        {
            if (greet != null)
            {
                greet(person, time);
            }
            Hello greetByPerson = new Hello(person.Greatings);
            greet += greetByPerson;
            Bye byeByPerson = new Bye(person.Goodbye);
            bye += byeByPerson;
            Console.WriteLine($"{person.PersonName} came!");
        }

        public void PersonGone (Person person)
        {
            Hello greetByPerson = new Hello(person.Greatings);
            greet = greetByPerson;
            person.Came -= PersonCame;
            Bye byeByPerson = new Bye(person.Goodbye);
            bye = byeByPerson;
            if (bye != null)
            {
                bye(person);
            }
            person.Gone -= PersonGone;
            Console.WriteLine($"{person.PersonName} gone!");
        }
    }
}
