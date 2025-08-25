using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
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
