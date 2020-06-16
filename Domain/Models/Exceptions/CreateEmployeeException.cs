using System.Linq;
using System.Collections;
using System;

namespace Models.Exceptions
{
    public class CreateEmployeeException : Exception
    {
        public CreateEmployeeException(string message) : base(message) { }

    }
}