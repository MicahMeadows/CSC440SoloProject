using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Exceptions
{
    class GetCourseException : Exception
    {
        public GetCourseException()
        {
        }

        public GetCourseException(string message) : base(message)
        {
        }

        public GetCourseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GetCourseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
