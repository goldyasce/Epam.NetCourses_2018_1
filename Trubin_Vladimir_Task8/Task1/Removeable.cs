using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Removeable<T> where T : IComparable<T>, new()
    {
        private List<T> list;
        private LinkedList<T> linkedList;
        public Removeable(List<T> list)
        {
            this.list = list;
        }

        public Removeable(LinkedList<T> linkedList)
        {
            this.linkedList = linkedList;
        }
        public Removeable()
        {

        }

        public void RemoveEachSecondItem(ICollection<T> list)
        {
            int counter = 0;
            while (list.Count > 1)
            {
                T[] array = new T[list.Count];
                int j = 0;
                T lastItem = default(T);

                foreach (T item in list)
                {
                    if (counter % 2 != 0)
                    {
                        array[j] = item;
                        j++;
                    }
                    counter++;
                    lastItem = item;
                }

                for (int i = 0; i < list.Count; i++)
                {
                    list.Remove(array[i]);
                }

                if (lastItem.CompareTo(list.Last()) == 0)
                {
                    counter = 1;
                }
                else
                {
                    counter = 0;
                }
            }
        }

        public void Write (ICollection<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"List1: {item}");
            }
        }
    }
}
