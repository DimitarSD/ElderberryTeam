namespace TeamElderberryProject
{
    using System;
    using System.Runtime.Serialization;

    public class InputException : Exception
    {
        public InputException()
            : base()
        {
        }

        public InputException(string message)
            : base(message)
        {
        }

        public InputException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InputException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}