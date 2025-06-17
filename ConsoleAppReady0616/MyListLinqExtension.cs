using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal static class MyListLinqExtension
    {
        public static IEnumerable<T> Where<T>(this MyList<T> source, Predicate<T> predicate) where T : IComparable<T>
        {
            List<T> lst = new List<T>();
            foreach(T tmp in source)
            {
                if (predicate(tmp))
                {
                    lst.Add(tmp);
                }
            }
            return lst;
        }
    }
}
