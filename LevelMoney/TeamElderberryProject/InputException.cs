using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject
{
    [Serializable]
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
