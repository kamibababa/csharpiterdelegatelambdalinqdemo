using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {

        T[] arr;
        int count;
        int position=-1;

        public MyEnumerator(T[] arr, int count)
        {
            this.arr = arr;
            this.count = count;
        }

        public T Current => this.arr[position];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(position < count)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            this.position = -1;
        }
    }
}
