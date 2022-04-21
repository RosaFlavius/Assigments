#define MYCONDITION
using ExceptionHandlingAndDebugging.Exceptions;
using ExceptionHandlingAndDebugging.Services;
using System;
using System.Diagnostics;


namespace MyApp 
{
   
    internal class Program
    {
        private static void Log(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        public static void verifyArguments(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Invalid input");
            }
            
        }

        static void Main(string[] args)
        {

#if MYCONDITION
         
             Console.WriteLine("Debugging");

#endif
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
                Debug.WriteLine("Program crashed, null parameters found");
                throw new Exception("Please enter valid parameters!!!");
            }
            catch (NotAnIntException e) {
                Debug.WriteLine("Program crashed, variable isn't an int");
            }
            catch (NotANumberException e) {
                Debug.WriteLine("Program crashed, variable isn't a number!");
            }
            catch (Exception e)
            {
                Log(e);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done!");
            }
            
            
        }
    }
}