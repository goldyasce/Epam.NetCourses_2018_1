using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 3, 5, 8, 10, 1, 6, 2, 7, 9, 4};
            int[] array1 = new int[5] { 11, 12, 13, 14, 15 };
            DynamicArray<int> arr = new DynamicArray<int>(array);

            //arr.AddRange(array1);
            //arr.Remove(1);
            //Console.WriteLine($"Capacity: { arr.Capacity}");
            arr.Sort(array);
            for (int i = 0; i < arr.Capacity; i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
