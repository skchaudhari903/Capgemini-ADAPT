/*Complete the code as instructed in the comment section to get the below output

Sample Output :

Attempted to divide by zero.

Your array index range is exceeded than defined

I am end of all exceptions

I am after exception
*/

using System;

public class ExceptionHandlingExample1
{

    public static void Main(string[] args)
    {
        try
        {
            int y = 0;
            int res = 10 / y;
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Attempted to divide by zero.");
        }

        try
        {
            int[] array = new int[5];
             Console.WriteLine(array[6]);
        }
        catch (IndexOutOfRangeException e1)
        {
            Console.WriteLine("Your array index range is exceeded than defined");
        }

        finally
        {
            Console.WriteLine("I am end of all exceptions");
        }
        
        Console.WriteLine("I am after exception");

    }

}
