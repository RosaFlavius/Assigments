using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging.Exceptions
{
    public class NotAnIntException : NotANumberException
    {
        public NotAnIntException(string message) : base(message) { }
    }
}
