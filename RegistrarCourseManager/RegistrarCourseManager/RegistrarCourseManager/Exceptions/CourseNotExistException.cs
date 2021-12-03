using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Exceptions
{
    class CourseNotExistException : Exception
    {
        public CourseNotExistException()
        {
        }

        public CourseNotExistException(string message) : base(message)
        {
        }

        public CourseNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CourseNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
