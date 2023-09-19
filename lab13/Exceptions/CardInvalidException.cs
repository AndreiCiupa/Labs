using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13.Exceptions
{
    public class CardInvalidException : Exception
    {
        public CardInvalidException(string message) : base(message) { }
    }
}
