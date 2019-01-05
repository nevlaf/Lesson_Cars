using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Exceptions
{
    public class MissingMileageException : Exception
    {
        public MissingMileageException()
        {
        }

        public MissingMileageException(string message) : base(message)
        {
        }

        public MissingMileageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingMileageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
