using System.Runtime.Serialization;

namespace lab13.Exceptions
{
    [Serializable]
    public class NrConexiuniMAxAtinsException : Exception
    {
        public NrConexiuniMAxAtinsException()
        {
        }

        public NrConexiuniMAxAtinsException(string? message) : base(message)
        {
        }

        public NrConexiuniMAxAtinsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NrConexiuniMAxAtinsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}