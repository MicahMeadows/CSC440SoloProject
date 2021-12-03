using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Exceptions
{
    class DeleteCourseException : Exception
    {
        public DeleteCourseException()
        {

        }

        public DeleteCourseException(string message) : base(message)
        {

        }

        public DeleteCourseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeleteCourseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
