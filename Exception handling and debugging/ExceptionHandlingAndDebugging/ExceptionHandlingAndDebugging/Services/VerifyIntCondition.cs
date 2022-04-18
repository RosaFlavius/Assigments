using ExceptionHandlingAndDebugging.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging.Services
{

    public class VerifyIntCondition
    {
        public static bool verifyInt(object obj)
        {
            if (!(obj is int))
            {

                throw new NotAnIntException("This variable it's not an int");
            }
            return true;
        }
    }
}
