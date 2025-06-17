using ConsoleAppReady0616;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal class MyList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private T[] arr;
        private int count;

        public MyList(int cap)
        {
            this.arr = new T[cap];
            this.count = 0;
        }

        public void Add(T item)
        {
            if(arr.Length <= count)
            {
                T[] newarr = new T[arr.Length * 2];
                for(int i = 0; i < arr.Length; i++)
                {
                    newarr[i] = arr[i];
                }
                this.arr = newarr;
            }
            this.arr[count] = item;
            count++;
        }

     

        public void output()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //public void Sort()
        //{
        //    for(int i = 0; i < count; i++)
        //    {
        //        for(int j = 0; j < count - i - 1; j++)
        //        {
        //            if (arr[j].CompareTo(arr[j + 1]) > 0)
        //            {
        //                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        //            }
        //        }
        //    }
        //}
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new MyEnumerator<T>(arr, count);
        //}
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
