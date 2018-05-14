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
            List<int> list = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            FillCollection(list, 15);
            Removeable<int> list2 = new Removeable<int>(list);
            list2.RemoveEachSecondItem(list);
            list2.Write(list);

            FillCollection(linkedList, 7);
            Removeable<int> list3 = new Removeable<int>(linkedList);
            list3.RemoveEachSecondItem(linkedList);
            list3.Write(linkedList);
            //FillCollection(linkedList, 25);
            //RemoveEachSecondItem(linkedList);
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine($"LinkedList: {item}");
            //}

            //FillCollection(list, 7);
            //RemoveEachSecondItem(list);
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"List: {item}");
            //}
            //RemoveEachSecondItem(list1);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine($"List1: {item}");
            //}

            Console.ReadLine();
        }

        //public static void RemoveEachSecondItem(ICollection<T> list)
        //{
        //    int counter = 0;
        //    while (list.Count > 1)
        //    {
        //        T[] array = new T[list.Count];
        //        int j = 0;
        //        T lastItem ;
                
        //        foreach (T item in list)
        //        {
        //            if (counter % 2 != 0)
        //            {
        //                array[j] = item;
        //                j++;
        //            }
        //            counter++;
        //            lastItem = item;
        //        }
                
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            list.Remove(array[i]);
        //        }

        //        if (lastItem == list.Last())
        //        {
        //            counter = 1;
        //        }
        //        else
        //        {
        //            counter = 0;
        //        }
        //    }
        //}

        public static void FillCollection (ICollection<int> collection, int length)
        {
            length++;
            for (int i = 1; i < length; i++)
            {
                collection.Add(i);
            }
        }
    }
}
