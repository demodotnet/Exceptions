using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        /*
         * What is exception?
         * An exception is nothing but runtime error.
         * 
         * What is exception handling?
         * Exception handling is a predefined mechanism to handle runtime errors
         * by using try,catch and finally blocks.
         * 
         * purpose of exception handling?
         * To handle runtime errors we will go for exception handling 
         * whenever an errors occured while executing the program,
         * program execution will not terminate , if we have implemented
         * exception handling mechanism and it will display user friendly
         * error message.
         * To implement exception handling mechanism microsoft is providing
         * a collection of predefined class for .net programmers like
         * 1)DivideByZeroException class.
         * 2)OVerflow exception class.
         * 3)FOrmat exception class.
         * 4)Arithmetic exception class.
         * syntax for try,catch and finally blocks.
         * try
         * {
         * }
         * catch(<Exeption>,<objectname>) here exception class is predefined and where as object name is userdefiend.
         * {
         * }
         * finally
         * {
         * }
         * within the try block we have to write the statements which may through an error.
         * With in catch blcok we have to write the code to handle the error by displaying
         * user friendly message.
         * with in finally block we have to write error free code execute irrespective of error occurance.
         */
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a numer");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int b = int.Parse(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("value of c is " + c);
            }
            catch (DivideByZeroException D)
            {
                Console.WriteLine("Please enter b value other than zero");
            }
            catch (FormatException F)
            {
                Console.WriteLine("Please enter only numbers");
            }
            catch (ArgumentOutOfRangeException E)
            {
                Console.WriteLine("Please enter with in the integer range");
            }
            finally
            {
                Console.WriteLine("Irrespective of error code will execute");
            }
        }
    }
}
