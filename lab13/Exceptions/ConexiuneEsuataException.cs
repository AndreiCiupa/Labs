using System.Runtime.Serialization;

namespace lab13.Exceptions
{
    [Serializable]
    public class ConexiuneEsuataException : Exception
    {
        public ConexiuneEsuataException()
        {
        }

        public ConexiuneEsuataException(string? message) : base(message)
        {
        }

        public ConexiuneEsuataException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ConexiuneEsuataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}