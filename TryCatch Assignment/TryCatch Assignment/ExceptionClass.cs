using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch_Assignment
{
    public class ExceptionClass : Exception
    {
        public ExceptionClass()
            : base() { }
        public ExceptionClass(string message)
            : base(message) { }
    }
}
