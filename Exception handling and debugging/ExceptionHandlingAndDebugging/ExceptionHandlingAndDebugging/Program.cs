using ExceptionHandlingAndDebugging.Exceptions;
using ExceptionHandlingAndDebugging.Services;
using System;

namespace MyApp 
{
   
    internal class Program
    {

        public static void verifyArguments(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Invalid input");
            }
            
        }

        static void Main(string[] args)
        {
            try
            {
                int a = 12;
                /*object a = null;
                verifyArguments(a);*/
                //float a = 15.5f;
                //double a = 12.3; //throws NotAnIntException
               //string a = "Hello!"; //throws NotANumberException

                VerifyNumberCondition.verifyNumber(a);
                VerifyIntCondition.verifyInt(a);
            }
            catch (ArgumentNullException e)
            {
                throw new Exception("Please enter valid parameters!!!");
            }
            catch (NotAnIntException e) { }
            catch (NotANumberException e) { }
            
            
            
        }
    }
}