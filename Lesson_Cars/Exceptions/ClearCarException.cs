using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Exceptions
{
    public class ClearCarException : Exception
    {
        public ClearCarException()
        {
        }

        public ClearCarException(string message) : base(message)
        {
        }

        public ClearCarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClearCarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
