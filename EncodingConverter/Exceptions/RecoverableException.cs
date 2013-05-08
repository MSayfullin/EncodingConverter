using System;

namespace dokas.EncodingConverter.Exceptions
{
    internal class RecoverableException : Exception
    {
        public RecoverableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
