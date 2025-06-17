using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal class AgeArgumentErrorException : Exception
    {
        public AgeArgumentErrorException(string? message) : base(message)
        {

        }
    }
}
