using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class DynamicArray<T> : IEnumerable<T> where T : IComparable<T>, new()
    {
        private T[] array;
        private int length;

        public int Length { get; }

        public int Capacity { get; }

        public DynamicArray()
        {
            array = new T[8];
            Capacity = 8;
        }

        public DynamicArray(int Elements)
        {
            array = new T[Elements];
            Capacity = Elements;
        }

        public DynamicArray(T[] array)
        {
            this.array = array ?? throw new NullReferenceException("Array can't be null");
            Capacity = array.Length;
            length = array.Length;
        }

        public DynamicArray (IEnumerable<T> enumerable)
	    {
            array = enumerable.ToArray<T>();
            length = array.Length;
	    }

        public void Add (T element)
        {
            if (length == Capacity)
            {
                IncreaseCapacity(Capacity);
                array[length] = element;
                length++;
            }
            else
            {
                array[length] = element;
                length++;
            }
        }

        public void AddRange(T[] arr)
        {
            if (arr.Length + length > Capacity)
            {
                IncreaseCapacity(Capacity, arr);
            }
            else
            {
                IncreaseCapacity(Capacity);
            }

            arr.CopyTo(array, length);
            length = length + arr.Length;
        }

        public bool Remove (T element)
        {
            int index = Array.IndexOf(array, element);
            if (index == -1)
            {
                return false;
            }
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            length--;
            array[length] = default(T);
            return true;
        }

        public void RemoveAt (int index)
        {
            if (index > length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            else
            {
                T[] interArray = new T[length - index - 1];
                Array.ConstrainedCopy(array, index + 1, interArray, 0, length - index - 1);
                interArray.CopyTo(array, index);
                array[length] = default(T);
                length--;
            }
        }

        public void Insert (int index, T element)
        {
            if (index > length || index < 0)
            {
                throw new ArgumentException("Index is out of range");
            }
            else
            {
                if (length == Capacity)
                {
                    IncreaseCapacity(Capacity);
                }

                T[] interArray = new T[length - index + 1];
                Array.ConstrainedCopy(array, index, interArray, 1, length - index);
                interArray[0] = element;
                interArray.CopyTo(array, index);
                length++;
            }
        }

        public void Sort (T[] arr)
        {
            T k;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > length || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                else
                {
                    return array[index];
                }
            }
            set
            {
                if (index > length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                else
                {
                    array[index] = value;
                    if (index > length - 1)
                    {
                        length++;
                    }
                }
            }
        }

        private void IncreaseCapacity(int capacity, T[] arr)
        {
            capacity *= ((length + arr.Length) / capacity) + 1;
            T[] interArray = array;
            array = new T[capacity];
            interArray.CopyTo(array, 0);
        }
        private T[] IncreaseCapacity(int capacity)
        {
            capacity *= 2;
            T[] interArray = array;
            array = new T[capacity];
            interArray.CopyTo(array, 0);
            return array;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
