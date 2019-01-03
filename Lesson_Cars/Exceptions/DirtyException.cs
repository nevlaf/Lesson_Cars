using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Exceptions
{
    public class DirtyException : Exception
    {
        public DirtyException()
        {
        }

        public DirtyException(string message) : base(message)
        {
        }

        public DirtyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DirtyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
