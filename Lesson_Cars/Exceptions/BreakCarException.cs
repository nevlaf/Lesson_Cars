using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Exceptions
{
    public class BreakCarException : Exception
    {
        public BreakCarException()
        {
        }

        public BreakCarException(string message) : base(message)
        {
        }

        public BreakCarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BreakCarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
