using System;

namespace ProductManager.Exceptions
{
    internal class EmptyAuthTokenException : Exception
    {
        private const string message = "The authToken is empty";

        public EmptyAuthTokenException() : base(message)
        {
        }
    }
}