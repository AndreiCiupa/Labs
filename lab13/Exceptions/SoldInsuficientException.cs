using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13.Exceptions
{
    public class SoldInsuficientException : Exception
    {
        public SoldInsuficientException(string message) : base(message) { }

    }
}
