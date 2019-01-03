using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Exceptions
{
    public class WastePathException : Exception
    {
        public WastePathException()
        {
        }

        public WastePathException(string message) : base(message)
        {
        }

        public WastePathException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WastePathException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
