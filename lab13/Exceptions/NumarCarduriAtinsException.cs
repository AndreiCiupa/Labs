using System.Runtime.Serialization;

namespace lab13.Exceptions
{
    [Serializable]
    internal class NumarCarduriAtinsException : Exception
    {
        public NumarCarduriAtinsException()
        {
        }

        public NumarCarduriAtinsException(string? message) : base(message)
        {
        }

        public NumarCarduriAtinsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NumarCarduriAtinsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}