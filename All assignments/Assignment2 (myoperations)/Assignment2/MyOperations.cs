using System;

namespace MyOperations
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; }

        public MyCustomException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {Message}";
        }
    }
}
