using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1307
{
    internal class Program
    {
     
        static void Main(string[] args)
        { /*
      Tasks#1.
Find out the top 10 commonly used Exceptions in c# with examples.

In C#, exceptions are used to handle errors and other exceptional conditions in a structured way.

1) System.Exception
The base class for all exceptions in C#. All other exception classes inherit from this class.

2) System.ArgumentException
Thrown when one of the arguments provided to a method is not valid.

3) System.ArgumentNullException
A subclass of ArgumentException that is thrown when a null argument is passed to a method that does not accept it.

4) System.ArgumentOutOfRangeException
A subclass of ArgumentException that is thrown when an argument is outside the range of valid values.

5) System.InvalidOperationException
Thrown when a method call is invalid for the object's current state.

6) System.NullReferenceException
Thrown when there is an attempt to dereference a null object reference.

7) System.IndexOutOfRangeException
Thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.

8) System.IO.IOException
The base class for exceptions thrown while accessing I/O, such as files or streams.

9) System.NotSupportedException
Thrown when an invoked method is not supported, or when there is an attempt to perform an operation that is not supported.

10) System.FormatException
Thrown when the format of an argument does not meet the parameter specifications of the invoked method.
     */

            int a, b, c;
            try
            {
                Console.WriteLine("Enter a value : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Result : " + c);
            }
            //catch(Exception ex)
         
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();

        }
    }
}
