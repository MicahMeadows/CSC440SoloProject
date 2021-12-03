using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Exceptions
{
    class AddGradeException : Exception
    {
        public AddGradeException()
        {
        }

        public AddGradeException(string message) : base(message)
        {
        }

        public AddGradeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AddGradeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
