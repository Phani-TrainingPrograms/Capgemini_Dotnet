using System;
using System.Net.Http.Headers;
/*
 * Exception Handling is a feature in most of the programming languages to handle unforseen behaviour of the Application flow that might lead to the crashing of the Application, which has to be resolved to bring back the application to the normal flow. 
 * It is created to handle runtime issues to allow the program to continue executing or gracefully shut down without crashing. 
 * try, catch, finally and throw are the important keywords in C# for exception handling. 
 * try block is used to wrap the code that might throw an exception. 
 * catch block is used to handle exceptions, U can have multiple catch for a given try block. This is required to handle different kinds of Exceptions. 
 * finally block is used to execute code that must run after the try block regardless of the exception.
 * try must have either catch, finally or both.
 * All Exceptions are object oriented classes that are derived from System.Exception. 
 * System.Exception shall be the last catch. Try if U could create a catch block that handles base Exception and allow other Exceptions to be handled after this catch.
 * U can create a Custom Exception to handle UR own business logic issues by creating a class derived from System.Exception and use throw keyword to raise that exception. 
 */

namespace CSharpBasics
{
    class EmpIdException : Exception
    {
        public EmpIdException()
        {
            
        }

        public EmpIdException(string message) : base(message)
        {

        }        
        
        public EmpIdException(string message, Exception innerException) :base(message, innerException) {
        

        }
    }
    internal class ExceptionHandlingExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
        RETRY:
            try
            {
                int no = int.Parse(Console.ReadLine());
                if ((no > 200) || (no < 100))
                {
                    throw new EmpIdException("No should be within 100 to 200");
                }
                Console.WriteLine("The no entered is " + no);
            }
            catch (FormatException)
            {
                Console.WriteLine("U must enter a valid integer value, Please try again");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The integer value is too big to hold. Please ener any value from {int.MinValue} to {int.MaxValue}. Please try again");
                goto RETRY;
            }
            catch (EmpIdException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto RETRY;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"We actually dont know what went wrong!, The system has given the detail as : {ex.Message}. Please try again: ");
                goto RETRY;
            }
            
        }
    }
}
