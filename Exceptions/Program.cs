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
         * 
         * Execution flow of try,catch and finally :
         * While executing try block when there is an error control will
         * comeout from try block and it will execute oppropriate catch block then
         * it will execute finally block.
         * While executing try block if there is no error then it will execute full
         * try block and it will skip catch block and it will execute finally block.
         * Catch block will execute only when there is an error ,
         * but finally block will execute always irrespective of error occurance.
         * a try block can follow with one catch block or multiple catch blocks. and 
         * with finally or with out finally.
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
