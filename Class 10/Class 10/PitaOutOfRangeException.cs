using System;
using System.Runtime.Serialization;

namespace Class_10
{
    [Serializable]
    internal class PitaOutOfRangeException : Exception
    {
        public PitaOutOfRangeException()
        {
        }

        public PitaOutOfRangeException(string message) : base(message)
        {
        }

        public PitaOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PitaOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}