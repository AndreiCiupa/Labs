using System.Runtime.Serialization;

namespace lab13.Exceptions
{
    public class NumarCarduriAtinsException : Exception
    {
        public NumarCarduriAtinsException(string message) : base(message) { }
    }
}