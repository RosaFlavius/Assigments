using ExceptionHandlingAndDebugging.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging.Services
{
    public class VerifyNumberCondition
    {
        public static bool verifyNumber(object obj)
        {
            if (!((obj is int) || (obj is double)))
            {

                throw new NotANumberException(obj + " it's not a number");
            }
            return true;
        }
    }
}
