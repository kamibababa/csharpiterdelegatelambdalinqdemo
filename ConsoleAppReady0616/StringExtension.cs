using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal static class StringExtension
    {
        public static string Multiply(this string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }
    }
}
