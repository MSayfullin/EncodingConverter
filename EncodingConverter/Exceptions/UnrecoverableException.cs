using System;

namespace dokas.EncodingConverter.Exceptions
{
    internal class UnrecoverableException : Exception
    {
        public UnrecoverableException(string message) : base(message)
        {
        }
    }
}
